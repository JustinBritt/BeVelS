namespace BeVelS.Graphics.HTML.Classes
{
    using UltralightNet;

    using Veldrid;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.HTML.Interfaces;
    using BeVelS.Graphics.HTML.InterfacesFactories;
    using BeVelS.Graphics.Textures.Interfaces;
    using BeVelS.Graphics.Textures.InterfacesFactories;

    internal sealed class RenderableHTML : IRenderableHTML
    {
        public RenderableHTML(
            IVector2Factory vector2Factory,
            IHTMLTextureFactory HTMLTextureFactory,
            ITextureContentFactory textureContentFactory,
            GraphicsDevice graphicsDevice,
            ULBitmap[] ULBitmaps)
        {
            this.Texture = this.CreateTexture(
                graphicsDevice,
                HTMLTextureFactory.Create(
                    ULBitmaps));

            this.Content = textureContentFactory.Create(
                vector2Factory: vector2Factory,
                width: (int)this.Texture.Width,
                height: (int)this.Texture.Height,
                mipLevels: 1,
                texelSizeInBytes: 4);
        }

        public ITextureContent Content { get; }

        public Texture Texture { get; }

        private Texture CreateTexture(
            GraphicsDevice graphicsDevice,
            IHTMLTexture HTMLTexture)
        {
            return HTMLTexture.CreateTexture(
                graphicsDevice);
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                this.Texture.Dispose();
            }
        }
    }
}