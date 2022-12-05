namespace BeVelS.ECS.Systems.Framebuffers.Interfaces
{
    using BepuUtilities;

    using BeVelS.ECS.Systems.Interfaces;
    using BeVelS.ECS.Systems.RenderTargets.Interfaces;

    public interface IFramebufferingSystem : IPostUpdateSystem<float>
    {
        IColorBufferSystem ColorBufferSystem { get; }

        IDepthBufferSystem DepthBufferSystem { get; }

        IResolvedColorBufferSystem ResolvedColorBufferSystem { get; }

        void OnResize(
            Int2 resolution);

        public void PostUpdate(
            float state);
    }
}