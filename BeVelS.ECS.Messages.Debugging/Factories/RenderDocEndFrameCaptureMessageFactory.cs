namespace BeVelS.ECS.Messages.Debugging.Factories
{
    using System;

    using log4net;

    using BeVelS.ECS.Messages.Debugging.InterfacesFactories;
    using BeVelS.ECS.Messages.Debugging.Structs;

    internal sealed class RenderDocEndFrameCaptureMessageFactory : IRenderDocEndFrameCaptureMessageFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RenderDocEndFrameCaptureMessageFactory()
        {
        }

        public RenderDocEndFrameCaptureMessage Create()
        {
            RenderDocEndFrameCaptureMessage message = default;

            try
            {
                message = new RenderDocEndFrameCaptureMessage();
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