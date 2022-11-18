namespace BeVelS.ECS.Systems.Framebuffers.InterfacesFactories
{
    using DefaultEcs;

    using BeVelS.ECS.Systems.Framebuffers.Interfaces;
    using BeVelS.ECS.Systems.InterfacesFactories;
    using BeVelS.ECS.Systems.RenderTargets.InterfacesFactories;

    using BeVelS.Graphics.Framebuffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Textures.InterfacesFactories;

    public interface IFramebufferingSystemFactory
    {
        IFramebufferingSystem Create(
            ISequentialSystemFactory sequentialSystemFactory,
            IFramebufferSystemFactory framebufferSystemFactory,
            IResolvedFramebufferSystemFactory resolvedFramebufferSystemFactory,
            IColorBufferSystemFactory colorBufferSystemFactory,
            IDepthBufferSystemFactory depthBufferSystemFactory,
            IResolvedColorBufferSystemFactory resolvedColorBufferSystemFactory,
            IFramebufferDescriptionFactory framebufferDescriptionFactory,
            ITextureFactory textureFactory,
            World world);
    }
}