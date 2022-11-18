namespace BeVelS.ECS.Systems.RenderSurfaces.InterfacesAbstractFactories
{
    using BeVelS.ECS.Systems.RenderSurfaces.InterfacesFactories;

    public interface IRenderSurfacesAbstractFactory
    {
        IRenderSurfaceSystemFactory CreateRenderSurfaceSystemFactory();
    }
}