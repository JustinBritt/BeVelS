namespace BeVelS.ECS.Systems.GraphicsDevices.Interfaces
{
    using DefaultEcs.System;

    using Veldrid;

    public interface IGraphicsDeviceSystem : ISystem<float>
    {
        GraphicsDevice GraphicsDevice { get; }

        void PostUpdate(
            float state);
    }
}