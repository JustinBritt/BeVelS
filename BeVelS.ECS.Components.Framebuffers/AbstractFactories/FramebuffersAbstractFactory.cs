namespace BeVelS.ECS.Components.Framebuffers.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Components.Framebuffers.Factories;
    using BeVelS.ECS.Components.Framebuffers.InterfacesAbstractFactories;
    using BeVelS.ECS.Components.Framebuffers.InterfacesFactories;

    public sealed class FramebuffersAbstractFactory : IFramebuffersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FramebuffersAbstractFactory()
        {
        }

        public IResolvedFramebufferComponentFactory CreateResolvedFramebufferComponentFactory()
        {
            IResolvedFramebufferComponentFactory factory = null;

            try
            {
                factory = new ResolvedFramebufferComponentFactory();
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