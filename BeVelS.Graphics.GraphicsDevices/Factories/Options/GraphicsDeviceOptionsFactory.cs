namespace BeVelS.Graphics.GraphicsDevices.Factories.Options
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.GraphicsDevices.InterfacesFactories.Options;

    internal sealed class GraphicsDeviceOptionsFactory : IGraphicsDeviceOptionsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public GraphicsDeviceOptionsFactory()
        {
        }

        public GraphicsDeviceOptions Create()
        {
            GraphicsDeviceOptions graphicsDeviceOptions = default;

            try
            {
                graphicsDeviceOptions = new GraphicsDeviceOptions();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return graphicsDeviceOptions;
        }

        public GraphicsDeviceOptions Create(
            bool debug)
        {
            GraphicsDeviceOptions graphicsDeviceOptions = default;

            try
            {
                graphicsDeviceOptions = new GraphicsDeviceOptions(
                    debug);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return graphicsDeviceOptions;
        }

        public GraphicsDeviceOptions Create(
            bool debug,
            PixelFormat? swapchainDepthFormat,
            bool syncToVerticalBlank)
        {
            GraphicsDeviceOptions graphicsDeviceOptions = default;

            try
            {
                graphicsDeviceOptions = new GraphicsDeviceOptions(
                    debug,
                    swapchainDepthFormat,
                    syncToVerticalBlank);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return graphicsDeviceOptions;
        }

        public GraphicsDeviceOptions Create(
            bool debug,
            PixelFormat? swapchainDepthFormat,
            bool syncToVerticalBlank,
            ResourceBindingModel resourceBindingModel)
        {
            GraphicsDeviceOptions graphicsDeviceOptions = default;

            try
            {
                graphicsDeviceOptions = new GraphicsDeviceOptions(
                    debug,
                    swapchainDepthFormat,
                    syncToVerticalBlank,
                    resourceBindingModel);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return graphicsDeviceOptions;
        }

        public GraphicsDeviceOptions Create(
            bool debug,
            PixelFormat? swapchainDepthFormat,
            bool syncToVerticalBlank,
            ResourceBindingModel resourceBindingModel,
            bool preferDepthRangeZeroToOne)
        {
            GraphicsDeviceOptions graphicsDeviceOptions = default;

            try
            {
                graphicsDeviceOptions = new GraphicsDeviceOptions(
                    debug,
                    swapchainDepthFormat,
                    syncToVerticalBlank,
                    resourceBindingModel,
                    preferDepthRangeZeroToOne);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return graphicsDeviceOptions;
        }

        public GraphicsDeviceOptions Create(
            bool debug,
            PixelFormat? swapchainDepthFormat,
            bool syncToVerticalBlank,
            ResourceBindingModel resourceBindingModel,
            bool preferDepthRangeZeroToOne,
            bool preferStandardClipSpaceYDirection)
        {
            GraphicsDeviceOptions graphicsDeviceOptions = default;

            try
            {
                graphicsDeviceOptions = new GraphicsDeviceOptions(
                    debug,
                    swapchainDepthFormat,
                    syncToVerticalBlank,
                    resourceBindingModel,
                    preferDepthRangeZeroToOne,
                    preferStandardClipSpaceYDirection);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return graphicsDeviceOptions;
        }

        public GraphicsDeviceOptions Create(
            bool debug,
            PixelFormat? swapchainDepthFormat,
            bool syncToVerticalBlank,
            ResourceBindingModel resourceBindingModel,
            bool preferDepthRangeZeroToOne,
            bool preferStandardClipSpaceYDirection,
            bool swapchainSrgbFormat)
        {
            GraphicsDeviceOptions graphicsDeviceOptions = default;

            try
            {
                graphicsDeviceOptions = new GraphicsDeviceOptions(
                    debug,
                    swapchainDepthFormat,
                    syncToVerticalBlank,
                    resourceBindingModel,
                    preferDepthRangeZeroToOne,
                    preferStandardClipSpaceYDirection,
                    swapchainSrgbFormat);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return graphicsDeviceOptions;
        }
    }
}