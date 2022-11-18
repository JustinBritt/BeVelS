namespace BeVelS.Graphics.GraphicsDevices.Factories
{
    using System;

    using log4net;

    using Veldrid;
    using Veldrid.Vk;

    using BeVelS.Graphics.GraphicsDevices.Extensions.Options;
    using BeVelS.Graphics.GraphicsDevices.InterfacesFactories;
    using BeVelS.Graphics.GraphicsDevices.InterfacesFactories.Options;
    using BeVelS.Graphics.Swapchains.InterfacesFactories.Descriptions;

    internal sealed class GraphicsDeviceFactory : IGraphicsDeviceFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public GraphicsDeviceFactory()
        {
        }

        public GraphicsDevice CreateD3D11Win32(
            IGraphicsDeviceOptionsFactory graphicsDeviceOptionsFactory,
            ISwapchainDescriptionFactory swapchainDescriptionFactory,
            uint height,
            IntPtr hwnd,
            IntPtr hinstance,
            PixelFormat pixelFormat,
            bool syncToVerticalBlank,
            uint width)
        {
            GraphicsDevice graphicsDevice = null;

            try
            {
                graphicsDevice = GraphicsDevice.CreateD3D11(
                    graphicsDeviceOptionsFactory.Create(),
                    swapchainDescriptionFactory.Create(
                        SwapchainSource.CreateWin32(
                            hwnd,
                            hinstance),
                        width,
                        height,
                        pixelFormat,
                        syncToVerticalBlank));
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return graphicsDevice;
        }

        public GraphicsDevice CreateVulkanWin32(
            IGraphicsDeviceOptionsFactory graphicsDeviceOptionsFactory,
            ISwapchainDescriptionFactory swapchainDescriptionFactory,
            uint height,
            IntPtr hwnd,
            IntPtr hinstance,
            PixelFormat pixelFormat,
            bool syncToVerticalBlank,
            VulkanDeviceOptions VulkanDeviceOptions,
            uint width)
        {
            GraphicsDevice graphicsDevice = null;

            try
            {
                graphicsDevice = GraphicsDevice.CreateVulkan(
                    graphicsDeviceOptionsFactory.Create().WithPreferStandardClipSpaceYDirection(),
                    swapchainDescriptionFactory.Create(
                        SwapchainSource.CreateWin32(
                            hwnd,
                            hinstance),
                        width,
                        height,
                        pixelFormat,
                        syncToVerticalBlank),
                    VulkanDeviceOptions);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return graphicsDevice;
        }
    }
}