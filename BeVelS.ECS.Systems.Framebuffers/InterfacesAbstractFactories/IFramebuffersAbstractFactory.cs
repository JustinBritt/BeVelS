namespace BeVelS.ECS.Systems.Framebuffers.InterfacesAbstractFactories
{
    using BeVelS.ECS.Systems.Framebuffers.InterfacesFactories;

    public interface IFramebuffersAbstractFactory
    {
        IFramebufferingSystemFactory CreateFramebufferingSystemFactory();

        IFramebufferSystemFactory CreateFramebufferSystemFactory();

        IResolvedFramebufferSystemFactory CreateResolvedFramebufferSystemFactory();
    }
}