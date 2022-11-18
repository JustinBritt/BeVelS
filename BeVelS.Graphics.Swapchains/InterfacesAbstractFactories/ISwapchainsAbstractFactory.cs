namespace BeVelS.Graphics.Swapchains.InterfacesAbstractFactories
{
    using BeVelS.Graphics.Swapchains.InterfacesFactories.Descriptions;

    public interface ISwapchainsAbstractFactory
    {
        ISwapchainDescriptionFactory CreateSwapchainDescriptionFactory();
    }
}