namespace BeVelS.Graphics.Textures.Factories
{
    using log4net;

    using Veldrid;

    using BeVelS.Graphics.Textures.InterfacesFactories;

    internal sealed class TextureFactory : ITextureFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TextureFactory()
        {
        }

        public Texture Create(
            uint arrayLayers,
            GraphicsDevice graphicsDevice,
            uint height,
            uint mipLevels,
            PixelFormat pixelFormat,
            TextureSampleCount textureSampleCount,
            TextureUsage textureUsage,
            uint width)
        {
            return graphicsDevice.ResourceFactory.CreateTexture(
                TextureDescription.Texture2D(
                    width: width,
                    height: height,
                    mipLevels: mipLevels,
                    arrayLayers: arrayLayers,
                    format: pixelFormat,
                    usage: textureUsage,
                    sampleCount: textureSampleCount));
        }
    }
}