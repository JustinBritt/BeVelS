namespace BeVelS.ECS.Messages.Renderers.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Messages.Renderers.Factories;
    using BeVelS.ECS.Messages.Renderers.InterfacesAbstractFactories;
    using BeVelS.ECS.Messages.Renderers.InterfacesFactories;

    public sealed class RenderersAbstractFactory : IRenderersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RenderersAbstractFactory()
        {
        }

        public IRenderableHTMLDrawMessageFactory CreateRenderableHTMLDrawMessageFactory()
        {
            IRenderableHTMLDrawMessageFactory factory = null;

            try
            {
                factory = new RenderableHTMLDrawMessageFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IRenderableImageDrawMessageFactory CreateRenderableImageDrawMessageFactory()
        {
            IRenderableImageDrawMessageFactory factory = null;

            try
            {
                factory = new RenderableImageDrawMessageFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITextBuilderWriteMessageFactory CreateTextBuilderWriteMessageFactory()
        {
            ITextBuilderWriteMessageFactory factory = null;

            try
            {
                factory = new TextBuilderWriteMessageFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IUILineDrawMessageFactory CreateUILineDrawMessageFactory()
        {
            IUILineDrawMessageFactory factory = null;

            try
            {
                factory = new UILineDrawMessageFactory();
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