namespace BeVelS.Graphics.Framebuffers.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.Framebuffers.Factories.Descriptions;
    using BeVelS.Graphics.Framebuffers.InterfacesAbstractFactories;
    using BeVelS.Graphics.Framebuffers.InterfacesFactories.Descriptions;

    public sealed class FramebuffersAbstractFactory : IFramebuffersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        public FramebuffersAbstractFactory()
        {
        }

        public IFramebufferDescriptionFactory CreateFramebufferDescriptionFactory()
        {
            IFramebufferDescriptionFactory factory = null;

            try
            {
                factory = new FramebufferDescriptionFactory();
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