namespace BeVelS.ECS.Systems.GraphicsDevices.Interfaces
{
    using Veldrid;

    using BeVelS.ECS.Systems.Interfaces;

    public interface IGraphicsDeviceSystem : IPostUpdateSystem<float>
    {
        GraphicsDevice GraphicsDevice { get; }
    }
}