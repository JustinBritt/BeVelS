namespace BeVelS.Graphics.HTML.Factories
{
    using System;

    using log4net;

    using BeVelS.Graphics.HTML.Classes;
    using BeVelS.Graphics.HTML.Interfaces;
    using BeVelS.Graphics.HTML.InterfacesFactories;

    internal sealed class RenderableHTMLsFactory : IRenderableHTMLsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RenderableHTMLsFactory()
        {
        }

        public IRenderableHTMLs Create()
        {
            IRenderableHTMLs renderableHTMLs = null;

            try
            {
                renderableHTMLs = new RenderableHTMLs();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return renderableHTMLs;
        }
    }
}