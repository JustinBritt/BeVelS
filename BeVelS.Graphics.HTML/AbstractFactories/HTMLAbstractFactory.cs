namespace BeVelS.Graphics.HTML.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.HTML.Factories;
    using BeVelS.Graphics.HTML.Factories.Batches;
    using BeVelS.Graphics.HTML.InterfacesAbstractFactories;
    using BeVelS.Graphics.HTML.InterfacesFactories;
    using BeVelS.Graphics.HTML.InterfacesFactories.Batches;

    public sealed class HTMLAbstractFactory : IHTMLAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HTMLAbstractFactory()
        {
        }

        public IHTMLBatchFactory CreateHTMLBatchFactory()
        {
            IHTMLBatchFactory factory = null;

            try
            {
                factory = new HTMLBatchFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IHTMLInstanceFactory CreateHTMLInstanceFactory()
        {
            IHTMLInstanceFactory factory = null;

            try
            {
                factory = new HTMLInstanceFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IHTMLTextureFactory CreateHTMLTextureFactory()
        {
            IHTMLTextureFactory factory = null;

            try
            {
                factory = new HTMLTextureFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IRenderableHTMLFactory CreateRenderableHTMLFactory()
        {
            IRenderableHTMLFactory factory = null;

            try
            {
                factory = new RenderableHTMLFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IRenderableHTMLsFactory CreateRenderableHTMLsFactory()
        {
            IRenderableHTMLsFactory factory = null;

            try
            {
                factory = new RenderableHTMLsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IULBitmapRendererFactory CreateULBitmapRendererFactory()
        {
            IULBitmapRendererFactory factory = null;

            try
            {
                factory = new ULBitmapRendererFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IULConfigFactory CreateULConfigFactory()
        {
            IULConfigFactory factory = null;

            try
            {
                factory = new ULConfigFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IULViewConfigFactory CreateULViewConfigFactory()
        {
            IULViewConfigFactory factory = null;

            try
            {
                factory = new ULViewConfigFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}