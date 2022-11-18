namespace BeVelS.ECS.Systems.Recorders.Interfaces
{
    using DefaultEcs.System;

    using BeVelS.Graphics.Recorders.Interfaces;

    public interface IFrameRecordingSystem : ISystem<float>
    {
        uint FrameCount { get; }

        IFrameRecorder FrameRecorder { get; }
    }
}