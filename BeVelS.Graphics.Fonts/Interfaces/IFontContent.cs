namespace BeVelS.Graphics.Fonts.Interfaces
{
    using System.Collections.Generic;

    using BeVelS.Graphics.Fonts.Structs.Characters;
    using BeVelS.Graphics.Textures.Interfaces;

    public interface IFontContent
    {
        ITextureContent Atlas { get; }

        Dictionary<char, CharacterData> Characters { get; }

        int GlyphCount { get; }

        float InverseSizeInTexels { get; }

        Dictionary<CharacterPair, int> Kerning { get; }

        string Name { get; }

        int GetKerningInTexels(
            char a,
            char b);
    }
}