namespace BeVelS.Graphics.GraphicsDevices.InterfacesFactories.Options
{
    using Veldrid;

    public interface IGraphicsDeviceOptionsFactory
    {
        GraphicsDeviceOptions Create();

        GraphicsDeviceOptions Create(
            bool debug);

        GraphicsDeviceOptions Create(
            bool debug,
            PixelFormat? swapchainDepthFormat,
            bool syncToVerticalBlank);

        GraphicsDeviceOptions Create(
            bool debug,
            PixelFormat? swapchainDepthFormat,
            bool syncToVerticalBlank,
            ResourceBindingModel resourceBindingModel);

        GraphicsDeviceOptions Create(
            bool debug,
            PixelFormat? swapchainDepthFormat,
            bool syncToVerticalBlank,
            ResourceBindingModel resourceBindingModel,
            bool preferDepthRangeZeroToOne);

        GraphicsDeviceOptions Create(
            bool debug,
            PixelFormat? swapchainDepthFormat,
            bool syncToVerticalBlank,
            ResourceBindingModel resourceBindingModel,
            bool preferDepthRangeZeroToOne,
            bool preferStandardClipSpaceYDirection);

        GraphicsDeviceOptions Create(
            bool debug,
            PixelFormat? swapchainDepthFormat,
            bool syncToVerticalBlank,
            ResourceBindingModel resourceBindingModel,
            bool preferDepthRangeZeroToOne,
            bool preferStandardClipSpaceYDirection,
            bool swapchainSrgbFormat);
    }
}