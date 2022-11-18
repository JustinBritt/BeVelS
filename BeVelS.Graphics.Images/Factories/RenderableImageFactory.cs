namespace BeVelS.Graphics.Images.Factories
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.Images.Classes;
    using BeVelS.Graphics.Images.Interfaces;
    using BeVelS.Graphics.Images.InterfacesFactories;
    using BeVelS.Graphics.Textures.InterfacesFactories;

    internal sealed class RenderableImageFactory : IRenderableImageFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RenderableImageFactory()
        {
        }

        public IRenderableImage Create(
            IVector2Factory vector2Factory,
            IImageSharpTextureFactory ImageSharpTextureFactory,
            ITextureContentFactory textureContentFactory,
            GraphicsDevice graphicsDevice,
            string path,
            bool mipmap = false,
            bool srgb = false)
        {
            IRenderableImage renderableImage = null;

            try
            {
                renderableImage = new RenderableImage(
                    vector2Factory: vector2Factory,
                    ImageSharpTextureFactory: ImageSharpTextureFactory,
                    textureContentFactory: textureContentFactory,
                    graphicsDevice: graphicsDevice,
                    path: path,
                    mipmap: mipmap,
                    srgb: srgb);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return renderableImage;
        }
    }
}