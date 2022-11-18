namespace BeVelS.Graphics.Recorders.Interfaces.Configurations
{
    using System;

    public interface IAnimatedGifRecorderConfiguration
    {
        Guid Guid { get; }

        string OutputDirectory { get; }

        string OutputPath { get; }
    }
}