namespace BeVelS.Graphics.Fonts.Interfaces
{
    using System;

    using Veldrid;

    public interface IFont : IDisposable
    {
        Texture AtlasStagingTexture { get; }

        IFontContent Content { get; }

        DeviceBuffer SourcesBuffer { get; }

        int GetSourceId(
            char character);
    }
}