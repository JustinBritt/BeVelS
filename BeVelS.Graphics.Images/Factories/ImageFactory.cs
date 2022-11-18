namespace BeVelS.Graphics.Images.Factories
{
    using System;

    using log4net;

    using SixLabors.ImageSharp;
    using SixLabors.ImageSharp.PixelFormats;

    using BeVelS.Graphics.Images.InterfacesFactories;

    internal sealed class ImageFactory : IImageFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ImageFactory()
        {
        }

        public Image<TPixel> Create<TPixel>(
            TPixel backgroundColor,
            int height,
            int width)
            where TPixel : unmanaged, IPixel<TPixel>
        {
            Image<TPixel> image = null;

            try
            {
                image = new Image<TPixel>(
                    configuration: Configuration.Default,
                    width: width,
                    height: height,
                    backgroundColor: backgroundColor);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return image;
        }
    }
}