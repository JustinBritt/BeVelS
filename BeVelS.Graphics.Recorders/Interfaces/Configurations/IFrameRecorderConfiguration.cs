namespace BeVelS.Graphics.Recorders.Interfaces.Configurations
{
    using System;

    public interface IFrameRecorderConfiguration
    {
        Func<uint, bool> IsFrameRecordable { get; }
    }
}