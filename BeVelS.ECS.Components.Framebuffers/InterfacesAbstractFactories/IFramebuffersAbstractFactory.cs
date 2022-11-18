namespace BeVelS.ECS.Components.Framebuffers.InterfacesAbstractFactories
{
    using BeVelS.ECS.Components.Framebuffers.InterfacesFactories;

    public interface IFramebuffersAbstractFactory
    {
        IResolvedFramebufferComponentFactory CreateResolvedFramebufferComponentFactory();
    }
}