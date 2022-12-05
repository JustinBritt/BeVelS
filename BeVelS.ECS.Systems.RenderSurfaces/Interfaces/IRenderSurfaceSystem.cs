namespace BeVelS.ECS.Systems.RenderSurfaces.Interfaces
{
    using BeVelS.ECS.Systems.GraphicsDevices.Interfaces;
    using BeVelS.ECS.Systems.Interfaces;
    using BeVelS.ECS.Systems.Resolutions.Interfaces;

    public interface IRenderSurfaceSystem : IPostUpdateSystem<float>
    {
        IGraphicsDeviceSystem GraphicsDeviceSystem { get; }

        IResolutionSystem ResolutionSystem { get; }
    }
}