namespace BeVelS.Graphics.Swapchains.Factories.Descriptions
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.Swapchains.InterfacesFactories.Descriptions;

    internal sealed class SwapchainDescriptionFactory : ISwapchainDescriptionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SwapchainDescriptionFactory()
        {
        }

        public SwapchainDescription Create(
            SwapchainSource source,
            uint width,
            uint height,
            PixelFormat? depthFormat,
            bool syncToVerticalBlank)
        {
            SwapchainDescription swapchainDescription = default;

            try
            {
                swapchainDescription = new SwapchainDescription(
                    source,
                    width,
                    height,
                    depthFormat,
                    syncToVerticalBlank);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return swapchainDescription;
        }

        public SwapchainDescription Create(
            SwapchainSource source,
            uint width,
            uint height,
            PixelFormat? depthFormat,
            bool syncToVerticalBlank,
            bool colorSrgb)
        {
            SwapchainDescription swapchainDescription = default;

            try
            {
                swapchainDescription = new SwapchainDescription(
                    source,
                    width,
                    height,
                    depthFormat,
                    syncToVerticalBlank,
                    colorSrgb);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return swapchainDescription;
        }
    }
}