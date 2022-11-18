namespace BeVelS.ECS.Systems.RenderSurfaces.Interfaces
{
    using DefaultEcs.System;

    using BeVelS.ECS.Systems.GraphicsDevices.Interfaces;
    using BeVelS.ECS.Systems.Resolutions.Interfaces;

    public interface IRenderSurfaceSystem : ISystem<float>
    {
        IGraphicsDeviceSystem GraphicsDeviceSystem { get; }

        IResolutionSystem ResolutionSystem { get; }

        void PostUpdate(
            float state);
    }
}