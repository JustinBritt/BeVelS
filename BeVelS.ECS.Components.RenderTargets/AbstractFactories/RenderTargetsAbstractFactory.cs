namespace BeVelS.ECS.Components.RenderTargets.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Components.RenderTargets.Factories;
    using BeVelS.ECS.Components.RenderTargets.InterfacesAbstractFactories;
    using BeVelS.ECS.Components.RenderTargets.InterfacesFactories;

    public sealed class RenderTargetsAbstractFactory : IRenderTargetsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RenderTargetsAbstractFactory()
        {
        }

        public IColorBufferComponentFactory CreateColorBufferComponentFactory()
        {
            IColorBufferComponentFactory factory = null;

            try
            {
                factory = new ColorBufferComponentFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IDepthBufferComponentFactory CreateDepthBufferComponentFactory()
        {
            IDepthBufferComponentFactory factory = null;

            try
            {
                factory = new DepthBufferComponentFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IResolvedColorBufferComponentFactory CreateResolvedColorBufferComponentFactory()
        {
            IResolvedColorBufferComponentFactory factory = null;

            try
            {
                factory = new ResolvedColorBufferComponentFactory();
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