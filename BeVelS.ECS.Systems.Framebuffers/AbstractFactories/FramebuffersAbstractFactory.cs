namespace BeVelS.ECS.Systems.Framebuffers.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Systems.Framebuffers.Factories;
    using BeVelS.ECS.Systems.Framebuffers.InterfacesAbstractFactories;
    using BeVelS.ECS.Systems.Framebuffers.InterfacesFactories;

    public sealed class FramebuffersAbstractFactory : IFramebuffersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FramebuffersAbstractFactory()
        {
        }

        public IFramebufferingSystemFactory CreateFramebufferingSystemFactory()
        {
            IFramebufferingSystemFactory factory = null;

            try
            {
                factory = new FramebufferingSystemFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IFramebufferSystemFactory CreateFramebufferSystemFactory()
        {
            IFramebufferSystemFactory factory = null;

            try
            {
                factory = new FramebufferSystemFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IResolvedFramebufferSystemFactory CreateResolvedFramebufferSystemFactory()
        {
            IResolvedFramebufferSystemFactory factory = null;

            try
            {
                factory = new ResolvedFramebufferSystemFactory();
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