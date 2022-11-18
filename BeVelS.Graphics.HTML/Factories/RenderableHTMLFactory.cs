namespace BeVelS.Graphics.HTML.Factories
{
    using System;

    using log4net;

    using UltralightNet;

    using Veldrid;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.HTML.Classes;
    using BeVelS.Graphics.HTML.Interfaces;
    using BeVelS.Graphics.HTML.InterfacesFactories;
    using BeVelS.Graphics.Textures.InterfacesFactories;

    internal sealed class RenderableHTMLFactory : IRenderableHTMLFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RenderableHTMLFactory()
        {
        }

        public IRenderableHTML Create(
            IVector2Factory vector2Factory,
            IHTMLTextureFactory HTMLTextureFactory,
            ITextureContentFactory textureContentFactory,
            GraphicsDevice graphicsDevice,
            ULBitmap[] ULBitmaps)
        {
            IRenderableHTML renderableHTML = null;

            try
            {
                renderableHTML = new RenderableHTML(
                    vector2Factory,
                    HTMLTextureFactory,
                    textureContentFactory,
                    graphicsDevice,
                    ULBitmaps);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return renderableHTML;
        }
    }
}