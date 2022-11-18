namespace BeVelS.ECS.Systems.GraphicsDevices.InterfacesAbstractFactories
{
    using BeVelS.ECS.Systems.GraphicsDevices.InterfacesFactories;

    public interface IGraphicsDevicesAbstractFactory
    {
        IGraphicsDeviceSystemFactory CreateGraphicsDeviceSystemFactory();
    }
}