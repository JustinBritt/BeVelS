namespace BeVelS.Graphics.Images.Classes
{
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Veldrid;

    using BeVelS.Common.Vectors.InterfacesFactories;
    
    using BeVelS.Graphics.Images.Interfaces;
    using BeVelS.Graphics.Images.InterfacesFactories;

    using BeVelS.Graphics.Textures.InterfacesFactories;

    internal sealed class RenderableImages : IRenderableImages
    {
        public List<IRenderableImage> images = new List<IRenderableImage>();

        public RenderableImages()
        {
        }

        public void Clear()
        {
            for (int i = 0; i < images.Count; i = i + 1)
            {
                images[i].Dispose();
            }

            this.images.Clear();
        }

        public ImmutableList<IRenderableImage> GetRenderableImages()
        {
            return this.images.ToImmutableList();
        }

        public void LoadGraphicalContent(
            IVector2Factory vector2Factory,
            IRenderableImageFactory renderableImageFactory,
            IImageSharpTextureFactory ImageSharpTextureFactory,
            ITextureContentFactory textureContentFactory,
            GraphicsDevice graphicsDevice,
            string path)
        {
            this.images.Add(
                renderableImageFactory.Create(
                    vector2Factory,
                    ImageSharpTextureFactory,
                    textureContentFactory,
                    graphicsDevice,
                    path));
        }
    }
}