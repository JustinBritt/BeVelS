namespace BeVelS.Graphics.Recorders.Interfaces
{
    using System;

    using SixLabors.ImageSharp;

    using Veldrid;

    public interface IFrameRecorder : IDisposable
    {
        Texture StagingTexture { get; }

        void CopyToStagingTexture(
            CommandList commandList,
            GraphicsDevice graphicsDevice,
            Texture sourceTexture);

        Image GetImage(
            GraphicsDevice graphicsDevice,
            Texture sourceTexture);
    }
}