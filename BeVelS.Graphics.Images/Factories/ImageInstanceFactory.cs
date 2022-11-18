namespace BeVelS.Graphics.Images.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BeVelS.Graphics.Images.InterfacesFactories;
    using BeVelS.Graphics.Images.Structs;

    internal sealed class ImageInstanceFactory : IImageInstanceFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ImageInstanceFactory()
        {
        }

        public ImageInstance Create(
            Vector2 start,
            Vector2 horizontalAxis,
            Vector2 size,
            Vector4 color,
            Vector2 screenToPackedScale)
        {
            ImageInstance instance = default;

            try
            {
                instance = new ImageInstance(
                    start: start,
                    horizontalAxis: horizontalAxis,
                    size: size,
                    color: color,
                    screenToPackedScale: screenToPackedScale);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }
    }
}