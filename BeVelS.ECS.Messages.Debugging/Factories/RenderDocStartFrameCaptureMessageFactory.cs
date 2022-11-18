namespace BeVelS.ECS.Messages.Debugging.Factories
{
    using System;

    using log4net;

    using BeVelS.ECS.Messages.Debugging.InterfacesFactories;
    using BeVelS.ECS.Messages.Debugging.Structs;

    internal sealed class RenderDocStartFrameCaptureMessageFactory : IRenderDocStartFrameCaptureMessageFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RenderDocStartFrameCaptureMessageFactory()
        {
        }

        public RenderDocStartFrameCaptureMessage Create()
        {
            RenderDocStartFrameCaptureMessage message = default;

            try
            {
                message = new RenderDocStartFrameCaptureMessage();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return message;
        }
    }
}