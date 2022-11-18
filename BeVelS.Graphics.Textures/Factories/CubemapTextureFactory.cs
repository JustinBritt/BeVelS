namespace BeVelS.Graphics.Textures.Factories
{
    using log4net;

    using SixLabors.ImageSharp;
    using SixLabors.ImageSharp.PixelFormats;

    using Veldrid;

    using BeVelS.Graphics.Textures.InterfacesFactories;

    internal sealed class CubemapTextureFactory : ICubemapTextureFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CubemapTextureFactory()
        {
        }

        public Texture Create(
            IImageSharpCubemapTextureFactory ImageSharpCubemapTextureFactory,
            GraphicsDevice graphicsDevice,
            Image<Rgba32> uniform,
            bool mipmap = true)
        {
            return ImageSharpCubemapTextureFactory.Create(
                positiveX: uniform,
                negativeX: uniform,
                positiveY: uniform,
                negativeY: uniform,
                positiveZ: uniform,
                negativeZ: uniform,
                mipmap: mipmap)
                .CreateDeviceTexture(
                gd: graphicsDevice,
                factory: graphicsDevice.ResourceFactory);
        }
    }
}