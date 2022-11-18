namespace BeVelS.ECS.Systems.Framebuffers.Interfaces
{
    using BepuUtilities;

    using DefaultEcs.System;

    using BeVelS.ECS.Systems.RenderTargets.Interfaces;

    public interface IFramebufferingSystem : ISystem<float>
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