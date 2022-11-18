namespace BeVelS.Graphics.Images.InterfacesFactories
{
    using Veldrid;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.Images.Interfaces;
    using BeVelS.Graphics.Textures.InterfacesFactories;

    public interface IRenderableImageFactory
    {
        IRenderableImage Create(
            IVector2Factory vector2Factory,
            IImageSharpTextureFactory ImageSharpTextureFactory,
            ITextureContentFactory textureContentFactory,
            GraphicsDevice graphicsDevice,
            string path,
            bool mipmap = false,
            bool srgb = false);
    }
}