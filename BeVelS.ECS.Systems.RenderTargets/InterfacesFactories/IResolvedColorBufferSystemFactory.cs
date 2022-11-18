namespace BeVelS.ECS.Systems.RenderTargets.InterfacesFactories
{
    using DefaultEcs;

    using BeVelS.ECS.Systems.RenderTargets.Interfaces;

    using BeVelS.Graphics.Textures.InterfacesFactories;

    public interface IResolvedColorBufferSystemFactory
    {
        IResolvedColorBufferSystem Create(
            ITextureFactory textureFactory,
            World world);
    }
}