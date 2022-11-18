namespace BeVelS.ECS.Systems.RenderTargets.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Systems.RenderTargets.Factories;
    using BeVelS.ECS.Systems.RenderTargets.InterfacesAbstractFactories;
    using BeVelS.ECS.Systems.RenderTargets.InterfacesFactories;

    public sealed class RenderTargetsAbstractFactory : IRenderTargetsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RenderTargetsAbstractFactory()
        {
        }

        public IColorBufferSystemFactory CreateColorBufferSystemFactory()
        {
            IColorBufferSystemFactory factory = null;

            try
            {
                factory = new ColorBufferSystemFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IDepthBufferSystemFactory CreateDepthBufferSystemFactory()
        {
            IDepthBufferSystemFactory factory = null;

            try
            {
                factory = new DepthBufferSystemFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IResolvedColorBufferSystemFactory CreateResolvedColorBufferSystemFactory()
        {
            IResolvedColorBufferSystemFactory factory = null;

            try
            {
                factory = new ResolvedColorBufferSystemFactory();
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