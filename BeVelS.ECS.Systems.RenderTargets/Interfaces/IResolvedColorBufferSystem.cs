namespace BeVelS.ECS.Systems.RenderTargets.Interfaces
{
    using BepuUtilities;

    using Veldrid;

    using DefaultEcs.System;

    public interface IResolvedColorBufferSystem : ISystem<float>
    {
        Texture ResolvedColorBuffer { get; }

        void OnResize(
            Int2 resolution);
    }
}