namespace BeVelS.Graphics.Framebuffers.Factories.Descriptions
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.Framebuffers.InterfacesFactories.Descriptions;

    internal sealed class FramebufferDescriptionFactory : IFramebufferDescriptionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FramebufferDescriptionFactory()
        {
        }

        public FramebufferDescription Create(
            Texture depthTarget,
            params Texture[] colorTargets)
        {
            FramebufferDescription framebufferDescription = default;

            try
            {
                framebufferDescription = new FramebufferDescription(
                    depthTarget,
                    colorTargets);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return framebufferDescription;
        }

        public FramebufferDescription Create(
            FramebufferAttachmentDescription? depthTarget,
            FramebufferAttachmentDescription[] colorTargets)
        {
            FramebufferDescription framebufferDescription = default;

            try
            {
                framebufferDescription = new FramebufferDescription(
                    depthTarget,
                    colorTargets);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return framebufferDescription;
        }
    }
}