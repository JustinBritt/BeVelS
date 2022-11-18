namespace BeVelS.Graphics.Images.Interfaces
{
    using System.Collections.Immutable;

    using Veldrid;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.Images.InterfacesFactories;
    using BeVelS.Graphics.Textures.InterfacesFactories;

    public interface IRenderableImages
    {
        void Clear();

        ImmutableList<IRenderableImage> GetRenderableImages();

        void LoadGraphicalContent(
            IVector2Factory vector2Factory,
            IRenderableImageFactory renderableImageFactory,
            IImageSharpTextureFactory ImageSharpTextureFactory,
            ITextureContentFactory textureContentFactory,
            GraphicsDevice graphicsDevice,
            string path);
    }
}