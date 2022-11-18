namespace BeVelS.ECS.Components.RenderTargets.InterfacesAbstractFactories
{
    using BeVelS.ECS.Components.RenderTargets.InterfacesFactories;

    public interface IRenderTargetsAbstractFactory
    {
        IColorBufferComponentFactory CreateColorBufferComponentFactory();

        IDepthBufferComponentFactory CreateDepthBufferComponentFactory();

        IResolvedColorBufferComponentFactory CreateResolvedColorBufferComponentFactory();
    }
}