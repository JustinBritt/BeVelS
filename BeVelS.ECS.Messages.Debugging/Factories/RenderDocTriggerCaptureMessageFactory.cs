namespace BeVelS.ECS.Messages.Debugging.Factories
{
    using System;

    using log4net;

    using BeVelS.ECS.Messages.Debugging.InterfacesFactories;
    using BeVelS.ECS.Messages.Debugging.Structs;

    internal sealed class RenderDocTriggerCaptureMessageFactory : IRenderDocTriggerCaptureMessageFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RenderDocTriggerCaptureMessageFactory()
        {
        }

        public RenderDocTriggerCaptureMessage Create()
        {
            RenderDocTriggerCaptureMessage message = default;

            try
            {
                message = new RenderDocTriggerCaptureMessage();
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