namespace BeVelS.ECS.Components.Framebuffers.InterfacesFactories
{
    using Veldrid;

    using BeVelS.ECS.Components.Framebuffers.Structs;

    public interface IResolvedFramebufferComponentFactory
    {
        ResolvedFramebufferComponent Create(
            Framebuffer value);
    }
}