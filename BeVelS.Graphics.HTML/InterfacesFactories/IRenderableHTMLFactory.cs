namespace BeVelS.Graphics.HTML.InterfacesFactories
{
    using UltralightNet;

    using Veldrid;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.HTML.Interfaces;
    using BeVelS.Graphics.Textures.InterfacesFactories;
    
    public interface IRenderableHTMLFactory
    {
        IRenderableHTML Create(
            IVector2Factory vector2Factory,
            IHTMLTextureFactory HTMLTextureFactory,
            ITextureContentFactory textureContentFactory,
            GraphicsDevice graphicsDevice,
            ULBitmap[] ULBitmaps);
    }
}