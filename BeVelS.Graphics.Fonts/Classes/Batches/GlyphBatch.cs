namespace BeVelS.Graphics.Fonts.Classes.Batches
{
    using System;
    using System.Numerics;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.Fonts.Interfaces;
    using BeVelS.Graphics.Fonts.Interfaces.Batches;
    using BeVelS.Graphics.Fonts.Structs.Characters;
    using BeVelS.Graphics.Glyphs.Structs;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/UI/GlyphBatch.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges)]
    public sealed class GlyphBatch : IGlyphBatch
    {
        GlyphInstance[] glyphs;
        public GlyphInstance[] Glyphs
        {
            get
            {
                return this.glyphs;
            }
        }

        public GlyphBatch(
            int initialCapacity = 128)
        {
            this.glyphs = new GlyphInstance[initialCapacity];
        }

        public int GlyphCount { get; private set; }

        public void Clear()
        {
            this.GlyphCount = 0;
        }

        public static float MeasureLength(
            ReadOnlySpan<char> characters,
            IFont font,
            float height)
        {
            if (characters.Length > 0)
            {
                char previousCharacter = characters[0];

                float scale = height * font.Content.InverseSizeInTexels;

                float length = 0;

                if (font.Content.Characters.TryGetValue(previousCharacter, out CharacterData firstCharacterData))
                    length += firstCharacterData.Advance;

                for (int i = 1; i < characters.Length; ++i)
                {
                    char character = characters[i];

                    if (font.Content.Characters.TryGetValue(character, out CharacterData characterData))
                    {
                        length += characterData.Advance + font.Content.GetKerningInTexels(previousCharacter, character);
                    }
                }

                return length * scale;
            }
            return 0;

        }

        public void Add(
            IVector2Factory vector2Factory,
            ReadOnlySpan<char> characters,
            int start,
            int count,
            Vector2 screenToPackedScale,
            Vector2 startingPosition,
            Vector2 horizontalAxis,
            Vector4 color,
            float height,
            IFont font)
        {
            float scale = height * font.Content.InverseSizeInTexels;

            // Note that we don't actually include glyphs for spaces, so this could result in an oversized allocation. Not very concerning; no effect on correctness.
            int potentiallyRequiredCapacity = this.GlyphCount + count;

            if (potentiallyRequiredCapacity > this.glyphs.Length)
            {
                Array.Resize(
                    ref this.glyphs,
                    Math.Max(
                        potentiallyRequiredCapacity,
                        this.glyphs.Length * 2));
            }

            Vector2 penPosition = startingPosition;

            Vector2 verticalAxis = vector2Factory.Create(
                -horizontalAxis.Y,
                horizontalAxis.X);

            int nextCharacterIndex = start;

            int characterEnd = start + count;

            while (true)
            {
                if (nextCharacterIndex >= characterEnd)
                    break;

                char character = characters[nextCharacterIndex++];

                // Only create a glyph for characters that our font actually has entries for. Others will just be skipped without advancing.
                if (font.Content.Characters.TryGetValue(character, out CharacterData characterData))
                {
                    //No point wasting time rendering a glyph with nothing in it. At least for any normal-ish font.
                    if (character != ' ')
                    {
                        ref GlyphInstance glyph = ref this.glyphs[GlyphCount++];

                        //Note subtraction on y component. In texture space, +1 is down, -1 is up.
                        Vector2 localOffsetToCharacter = vector2Factory.Create(
                            characterData.Bearing.X * scale,
                            characterData.Bearing.Y * scale);

                        Vector2 offsetToCharacter = localOffsetToCharacter.X * horizontalAxis - localOffsetToCharacter.Y * verticalAxis;

                        Vector2 minimum = penPosition + offsetToCharacter;

                        glyph = new GlyphInstance(
                            ref minimum,
                            ref horizontalAxis,
                            scale,
                            font.GetSourceId(
                                character),
                            ref color,
                            ref screenToPackedScale);
                    }

                    // Move the pen to the next character.
                    float advance = characterData.Advance;

                    if (nextCharacterIndex < characterEnd)
                        advance += font.Content.GetKerningInTexels(character, characters[nextCharacterIndex]);

                    penPosition += horizontalAxis * (scale * advance);
                }
            }
        }
    }
}