namespace BeVelS.Graphics.Fonts.Factories
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using log4net;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.Fonts.Classes;
    using BeVelS.Graphics.Fonts.Interfaces;
    using BeVelS.Graphics.Fonts.InterfacesFactories;
    using BeVelS.Graphics.Fonts.Structs.Characters;
    using BeVelS.Graphics.Textures.Interfaces;
    using BeVelS.Graphics.Textures.InterfacesFactories;
    
    internal sealed class FontContentFactory : IFontContentFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FontContentFactory()
        {
        }

        public IFontContent Create(
            ITextureContent atlas,
            string name,
            float inverseSizeInTexels,
            Dictionary<char, CharacterData> characterData,
            Dictionary<CharacterPair, int> kerningTable)
        {
            IFontContent fontContent = null;

            try
            {
                fontContent = new FontContent(
                    atlas,
                    name,
                    inverseSizeInTexels,
                    characterData,
                    kerningTable);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return fontContent;
        }

        public IFontContent Create(
            IVector2Factory vector2Factory,
            IFontPackerFactory fontPackerFactory,
            ITextureContentFactory textureContentFactory,
            string path)
        {
            IFontContent fontContent = null;

            using (Stream stream = File.OpenRead(path))
            {
                fontContent = FontBuilder.Build(
                    vector2Factory,
                    this,
                    fontPackerFactory,
                    textureContentFactory,
                    stream);
            }

            return fontContent;
        }
    }
}