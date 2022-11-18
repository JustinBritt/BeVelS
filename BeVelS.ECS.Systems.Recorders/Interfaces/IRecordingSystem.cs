namespace BeVelS.ECS.Systems.Recorders.Interfaces
{
    using DefaultEcs.System;

    public interface IRecordingSystem : ISystem<float>
    {
        IAnimatedGifRecordingSystem AnimatedGifRecordingSystem { get; }

        IFrameRecordingSystem FrameRecordingSystem { get; }
    }
}