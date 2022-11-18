namespace BeVelS.Graphics.Fonts.Classes
{
    using System.Collections.Generic;

    using BeVelS.Graphics.Fonts.Interfaces;
    using BeVelS.Graphics.Fonts.Structs.Characters;
    using BeVelS.Graphics.Textures.Interfaces;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoContentLoader/FontContent.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges)]
    internal sealed class FontContent : IFontContent
    {
        public FontContent(
            ITextureContent atlas,
            string name,
            float inverseSizeInTexels,
            Dictionary<char, CharacterData> characterData,
            Dictionary<CharacterPair, int> kerningTable)
        {
            this.GlyphCount = GlyphCount;

            this.Atlas = atlas;

            this.Name = name;

            this.InverseSizeInTexels = inverseSizeInTexels;

            this.Characters = characterData;

            this.Kerning = kerningTable;
        }

        public ITextureContent Atlas { get; }

        public Dictionary<char, CharacterData> Characters { get; }

        public int GlyphCount { get; }

        public float InverseSizeInTexels { get; }

        public Dictionary<CharacterPair, int> Kerning { get; }

        public string Name { get; }

        public int GetKerningInTexels(
            char a,
            char b)
        {
            if (this.Kerning.TryGetValue(new CharacterPair(a, b), out int pairKerning))
            {
                return pairKerning;
            }

            return 0;
        }
    }
}