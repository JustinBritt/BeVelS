namespace BeVelS.ECS.Messages.Debugging.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Messages.Debugging.Factories;
    using BeVelS.ECS.Messages.Debugging.InterfacesAbstractFactories;
    using BeVelS.ECS.Messages.Debugging.InterfacesFactories;

    public sealed class DebuggingAbstractFactory : IDebuggingAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DebuggingAbstractFactory()
        {
        }

        public IRenderDocEndFrameCaptureMessageFactory CreateRenderDocEndFrameCaptureMessageFactory()
        {
            IRenderDocEndFrameCaptureMessageFactory factory = null;

            try
            {
                factory = new RenderDocEndFrameCaptureMessageFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IRenderDocLaunchReplayUIMessageFactory CreateRenderDocLaunchReplayUIMessageFactory()
        {
            IRenderDocLaunchReplayUIMessageFactory factory = null;

            try
            {
                factory = new RenderDocLaunchReplayUIMessageFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IRenderDocStartFrameCaptureMessageFactory CreateRenderDocStartFrameCaptureMessageFactory()
        {
            IRenderDocStartFrameCaptureMessageFactory factory = null;

            try
            {
                factory = new RenderDocStartFrameCaptureMessageFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IRenderDocTriggerCaptureMessageFactory CreateRenderDocTriggerCaptureMessageFactory()
        {
            IRenderDocTriggerCaptureMessageFactory factory = null;

            try
            {
                factory = new RenderDocTriggerCaptureMessageFactory();
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