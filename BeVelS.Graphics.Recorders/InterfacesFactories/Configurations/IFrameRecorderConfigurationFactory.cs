namespace BeVelS.Graphics.Recorders.InterfacesFactories.Configurations
{
    using System;

    using BeVelS.Graphics.Recorders.Interfaces.Configurations;

    public interface IFrameRecorderConfigurationFactory
    {
        IFrameRecorderConfiguration Create(
            Func<uint, bool> isFrameRecordable);
    }
}