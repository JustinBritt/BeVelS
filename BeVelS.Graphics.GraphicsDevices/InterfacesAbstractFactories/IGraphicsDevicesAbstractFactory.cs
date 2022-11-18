namespace BeVelS.Graphics.GraphicsDevices.InterfacesAbstractFactories
{
    using BeVelS.Graphics.GraphicsDevices.InterfacesFactories;
    using BeVelS.Graphics.GraphicsDevices.InterfacesFactories.Options;

    public interface IGraphicsDevicesAbstractFactory
    {
        IGraphicsDeviceFactory CreateGraphicsDeviceFactory();

        IGraphicsDeviceOptionsFactory CreateGraphicsDeviceOptionsFactory();

        IVulkanDeviceOptionsFactory CreateVulkanDeviceOptionsFactory();
    }
}