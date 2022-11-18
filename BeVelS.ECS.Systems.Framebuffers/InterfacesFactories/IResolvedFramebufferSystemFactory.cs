namespace BeVelS.ECS.Systems.Framebuffers.InterfacesFactories
{
    using DefaultEcs;

    using BeVelS.ECS.Systems.Framebuffers.Interfaces;

    using BeVelS.Graphics.Framebuffers.InterfacesFactories.Descriptions;

    public interface IResolvedFramebufferSystemFactory
    {
        IResolvedFramebufferSystem Create(
            IFramebufferDescriptionFactory framebufferDescriptionFactory,
            World world);
    }
}