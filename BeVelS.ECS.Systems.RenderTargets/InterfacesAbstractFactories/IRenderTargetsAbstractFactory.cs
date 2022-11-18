namespace BeVelS.ECS.Systems.RenderTargets.InterfacesAbstractFactories
{
    using BeVelS.ECS.Systems.RenderTargets.InterfacesFactories;

    public interface IRenderTargetsAbstractFactory
    {
        IColorBufferSystemFactory CreateColorBufferSystemFactory();

        IDepthBufferSystemFactory CreateDepthBufferSystemFactory();

        IResolvedColorBufferSystemFactory CreateResolvedColorBufferSystemFactory();
    }
}