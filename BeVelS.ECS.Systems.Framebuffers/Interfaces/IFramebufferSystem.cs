namespace BeVelS.ECS.Systems.Framebuffers.Interfaces
{
    using BepuUtilities;

    using DefaultEcs.System;

    public interface IFramebufferSystem : ISystem<float>
    {
        void OnResize(
            Int2 resolution);
    }
}