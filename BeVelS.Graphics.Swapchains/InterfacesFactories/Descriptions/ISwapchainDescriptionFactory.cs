namespace BeVelS.Graphics.Swapchains.InterfacesFactories.Descriptions
{
    using Veldrid;

    public interface ISwapchainDescriptionFactory
    {
        SwapchainDescription Create(
            SwapchainSource source,
            uint width,
            uint height,
            PixelFormat? depthFormat,
            bool syncToVerticalBlank);

        SwapchainDescription Create(
            SwapchainSource source,
            uint width,
            uint height,
            PixelFormat? depthFormat,
            bool syncToVerticalBlank,
            bool colorSrgb);
    }
}