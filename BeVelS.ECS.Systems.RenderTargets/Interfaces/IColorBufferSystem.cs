namespace BeVelS.ECS.Systems.RenderTargets.Interfaces
{
    using BepuUtilities;

    using DefaultEcs.System;

    using Veldrid;

    public interface IColorBufferSystem : ISystem<float>
    {
        Texture ColorBuffer { get; }

        void OnResize(
            Int2 resolution);
    }
}