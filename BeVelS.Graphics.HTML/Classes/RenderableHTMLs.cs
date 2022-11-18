namespace BeVelS.Graphics.HTML.Classes
{
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using UltralightNet;

    using Veldrid;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.HTML.Interfaces;
    using BeVelS.Graphics.HTML.InterfacesFactories;

    using BeVelS.Graphics.Textures.InterfacesFactories;
    
    internal sealed class RenderableHTMLs : IRenderableHTMLs
    {
        public List<IRenderableHTML> HTMLs = new List<IRenderableHTML>();

        public RenderableHTMLs()
        {
        }

        public void Clear()
        {
            for (int i = 0; i < HTMLs.Count; i = i + 1)
            {
                HTMLs[i].Dispose();
            }

            this.HTMLs.Clear();
        }

        public ImmutableList<IRenderableHTML> GetRenderableHTMLs()
        {
            return this.HTMLs.ToImmutableList();
        }

        public void Load(
            IVector2Factory vector2Factory,
            IRenderableHTMLFactory renderableHTMLFactory,
            IHTMLTextureFactory HTMLTextureFactory,
            ITextureContentFactory textureContentFactory,
            GraphicsDevice graphicsDevice,
            ULBitmap[] ULBitmaps)
        {
            this.HTMLs.Add(
                renderableHTMLFactory.Create(
                    vector2Factory,
                    HTMLTextureFactory,
                    textureContentFactory,
                    graphicsDevice,
                    ULBitmaps));
        }
    }
}