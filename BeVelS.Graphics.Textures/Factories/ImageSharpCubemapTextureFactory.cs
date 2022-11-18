namespace BeVelS.Graphics.Textures.Factories
{
    using System;

    using log4net;

    using SixLabors.ImageSharp;
    using SixLabors.ImageSharp.PixelFormats;

    using Veldrid.ImageSharp;

    using BeVelS.Graphics.Textures.InterfacesFactories;
    
    internal sealed class ImageSharpCubemapTextureFactory : IImageSharpCubemapTextureFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ImageSharpCubemapTextureFactory()
        {
        }

        public ImageSharpCubemapTexture Create(
            Image<Rgba32> negativeX,
            Image<Rgba32> negativeY,
            Image<Rgba32> negativeZ,
            Image<Rgba32> positiveX,
            Image<Rgba32> positiveY,
            Image<Rgba32> positiveZ,
            bool mipmap = true)
        {
            ImageSharpCubemapTexture texture = null;

            try
            {
                texture = new ImageSharpCubemapTexture(
                    mipmap: mipmap,
                    negativeX: negativeX,
                    negativeY: negativeY,
                    negativeZ: negativeZ,
                    positiveX: positiveX,
                    positiveY: positiveY,
                    positiveZ: positiveZ);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return texture;
        }

        public ImageSharpCubemapTexture Create(
            Image<Rgba32> uniform,
            bool mipmap = true)
        {
            return this.Create(
                positiveX: uniform,
                negativeX: uniform,
                positiveY: uniform,
                negativeY: uniform,
                positiveZ: uniform,
                negativeZ: uniform,
                mipmap: mipmap);
        }
    }
}