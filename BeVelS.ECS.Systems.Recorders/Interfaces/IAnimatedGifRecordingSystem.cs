namespace BeVelS.ECS.Systems.Recorders.Interfaces
{
    using DefaultEcs.System;

    using BeVelS.Graphics.Recorders.Interfaces;

    public interface IAnimatedGifRecordingSystem : ISystem<float>
    {
        IAnimatedGifRecorder AnimatedGifRecorder { get; }
    }
}