namespace BeVelS.ECS.Systems.Cameras.Interfaces
{
    using BepuUtilities;

    using DefaultEcs.System;

    public interface ICameraSystem : ISystem<float>
    {
        void OnResize(
            Int2 resolution);
    }
}