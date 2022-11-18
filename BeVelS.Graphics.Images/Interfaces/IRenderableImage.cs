namespace BeVelS.Graphics.Images.Interfaces
{
    using System;

    using Veldrid;

    using BeVelS.Graphics.Textures.Interfaces;

    public interface IRenderableImage : IDisposable
    {
        ITextureContent Content { get; }

        Texture ImageTexture { get; }
    }
}