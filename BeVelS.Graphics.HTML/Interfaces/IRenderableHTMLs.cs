namespace BeVelS.Graphics.HTML.Interfaces
{
    using System.Collections.Immutable;

    using UltralightNet;

    using Veldrid;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.HTML.InterfacesFactories;
    using BeVelS.Graphics.Textures.InterfacesFactories;

    public interface IRenderableHTMLs
    {
        void Clear();

        ImmutableList<IRenderableHTML> GetRenderableHTMLs();

        void Load(
            IVector2Factory vector2Factory,
            IRenderableHTMLFactory renderableHTMLFactory,
            IHTMLTextureFactory HTMLTextureFactory,
            ITextureContentFactory textureContentFactory,
            GraphicsDevice graphicsDevice,
            ULBitmap[] ULBitmaps);
    }
}