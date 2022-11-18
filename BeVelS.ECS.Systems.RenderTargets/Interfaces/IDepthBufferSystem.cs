namespace BeVelS.ECS.Systems.RenderTargets.Interfaces
{
    using BepuUtilities;

    using DefaultEcs.System;

    using Veldrid;

    public interface IDepthBufferSystem : ISystem<float>
    {
        Texture DepthBuffer { get; }

        void OnResize(
            Int2 resolution);
    }
}