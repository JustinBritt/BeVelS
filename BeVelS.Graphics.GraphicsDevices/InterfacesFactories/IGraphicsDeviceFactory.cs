namespace BeVelS.Graphics.GraphicsDevices.InterfacesFactories
{
    using System;

    using Veldrid;

    using BeVelS.Graphics.GraphicsDevices.InterfacesFactories.Options;
    using BeVelS.Graphics.Swapchains.InterfacesFactories.Descriptions;

    public interface IGraphicsDeviceFactory
    {
        GraphicsDevice CreateD3D11Win32(
            IGraphicsDeviceOptionsFactory graphicsDeviceOptionsFactory,
            ISwapchainDescriptionFactory swapchainDescriptionFactory,
            uint height,
            IntPtr hwnd,
            IntPtr hinstance,
            PixelFormat pixelFormat,
            bool syncToVerticalBlank,
            uint width);

        GraphicsDevice CreateVulkanWin32(
            IGraphicsDeviceOptionsFactory graphicsDeviceOptionsFactory,
            ISwapchainDescriptionFactory swapchainDescriptionFactory,
            uint height,
            IntPtr hwnd,
            IntPtr hinstance,
            PixelFormat pixelFormat,
            bool syncToVerticalBlank,
            VulkanDeviceOptions VulkanDeviceOptions,
            uint width);
    }
}