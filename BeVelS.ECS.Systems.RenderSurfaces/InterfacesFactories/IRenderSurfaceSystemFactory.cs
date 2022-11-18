namespace BeVelS.ECS.Systems.RenderSurfaces.InterfacesFactories
{
    using System.Numerics;

    using DefaultEcs;

    using Veldrid;

    using BeVelS.ECS.Systems.GraphicsDevices.InterfacesFactories;
    using BeVelS.ECS.Systems.RenderSurfaces.Interfaces;
    using BeVelS.ECS.Systems.Resolutions.InterfacesFactories;

    public interface IRenderSurfaceSystemFactory
    {
        IRenderSurfaceSystem Create(
            IGraphicsDeviceSystemFactory graphicsDeviceSystemFactory,
            IResolutionSystemFactory resolutionSystemFactory,
            GraphicsDevice graphicsDevice,
            Vector2 resolution,
            World world);
    }
}