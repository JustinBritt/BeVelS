namespace BeVelS.Graphics.HTML.Interfaces
{
    using System;

    using Veldrid;

    using BeVelS.Graphics.Textures.Interfaces;
    
    public interface IRenderableHTML : IDisposable
    {
        ITextureContent Content { get; }

        Texture Texture { get; }
    }
}