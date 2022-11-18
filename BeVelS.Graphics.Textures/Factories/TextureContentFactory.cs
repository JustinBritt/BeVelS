namespace BeVelS.Graphics.Textures.Factories
{
    using System;

    using log4net;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.Textures.Classes;
    using BeVelS.Graphics.Textures.Interfaces;
    using BeVelS.Graphics.Textures.InterfacesFactories;

    internal sealed class TextureContentFactory : ITextureContentFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TextureContentFactory()
        {
        }

        public ITextureContent Create(
            IVector2Factory vector2Factory,
            int width,
            int height,
            int mipLevels,
            int texelSizeInBytes)
        {
            ITextureContent textureContent = null;

            try
            {
                textureContent = new TextureContent(
                    vector2Factory,
                    width: width,
                    height: height,
                    mipLevels: mipLevels,
                    texelSizeInBytes: texelSizeInBytes);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return textureContent;
        }
    }
}