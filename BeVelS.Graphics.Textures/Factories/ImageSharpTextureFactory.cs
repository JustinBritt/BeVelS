namespace BeVelS.Graphics.Textures.Factories
{
    using System;
    using System.IO;

    using log4net;

    using Veldrid;
    using Veldrid.ImageSharp;

    using BeVelS.Graphics.Textures.InterfacesFactories;

    internal sealed class ImageSharpTextureFactory : IImageSharpTextureFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ImageSharpTextureFactory()
        {
        }

        public ImageSharpTexture Create(
            GraphicsDevice graphicsDevice,
            string imagePath,
            bool mipmap = false,
            bool srgb = false)
        {
            ImageSharpTexture texture = null;

            try
            {
                using (Stream imageStream = File.OpenRead(imagePath))
                {
                    texture = new ImageSharpTexture(
                        stream: imageStream,
                        mipmap: mipmap,
                        srgb: srgb);
                }
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return texture;
        }
    }
}