namespace BeVelS.ECS.Systems.RenderTargets.InterfacesFactories
{
    using DefaultEcs;

    using BeVelS.ECS.Systems.RenderTargets.Interfaces;

    using BeVelS.Graphics.Textures.InterfacesFactories;

    public interface IDepthBufferSystemFactory
    {
        IDepthBufferSystem Create(
            ITextureFactory textureFactory,
            World world);
    }
}