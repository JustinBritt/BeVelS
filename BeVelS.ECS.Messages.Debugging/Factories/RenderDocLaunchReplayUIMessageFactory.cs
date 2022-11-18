namespace BeVelS.ECS.Messages.Debugging.Factories
{
    using System;

    using log4net;

    using BeVelS.ECS.Messages.Debugging.InterfacesFactories;
    using BeVelS.ECS.Messages.Debugging.Structs;

    internal sealed class RenderDocLaunchReplayUIMessageFactory : IRenderDocLaunchReplayUIMessageFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RenderDocLaunchReplayUIMessageFactory()
        {
        }

        public RenderDocLaunchReplayUIMessage Create()
        {
            RenderDocLaunchReplayUIMessage message = default;

            try
            {
                message = new RenderDocLaunchReplayUIMessage();
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