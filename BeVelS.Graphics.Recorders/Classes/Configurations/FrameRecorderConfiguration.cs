namespace BeVelS.Graphics.Recorders.Classes.Configurations
{
    using System;

    using BeVelS.Graphics.Recorders.Interfaces.Configurations;

    internal sealed class FrameRecorderConfiguration : IFrameRecorderConfiguration
    {
        public FrameRecorderConfiguration(
            Func<uint, bool> isFrameRecordable)
        {
            this.IsFrameRecordable = isFrameRecordable;
        }

        public Func<uint, bool> IsFrameRecordable { get; }
    }
}