namespace BeVelS.ECS.Systems.GraphicsDevices.InterfacesFactories
{
    using BeVelS.ECS.Systems.GraphicsDevices.Interfaces;

    using DefaultEcs;
    
    using Veldrid;

    public interface IGraphicsDeviceSystemFactory
    {
        IGraphicsDeviceSystem Create(
            GraphicsDevice graphicsDevice,
            World world);
    }
}