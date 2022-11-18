namespace BeVelS.Graphics.Fonts.InterfacesFactories
{
    using System.Collections.Generic;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.Fonts.Interfaces;
    using BeVelS.Graphics.Fonts.Structs.Characters;
    using BeVelS.Graphics.Textures.Interfaces;
    using BeVelS.Graphics.Textures.InterfacesFactories;

    public interface IFontContentFactory
    {
        IFontContent Create(
            ITextureContent atlas,
            string name,
            float inverseSizeInTexels,
            Dictionary<char, CharacterData> characterData,
            Dictionary<CharacterPair, int> kerningTable);

        IFontContent Create(
            IVector2Factory vector2Factory,
            IFontPackerFactory fontPackerFactory,
            ITextureContentFactory textureContentFactory,
            string path);
    }
}