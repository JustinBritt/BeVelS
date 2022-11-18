namespace BeVelS.ECS.Messages.CommandLists.Factories
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.ECS.Messages.CommandLists.InterfacesFactories;
    using BeVelS.ECS.Messages.CommandLists.Structs;

    internal sealed class CommandListSubmitCommandsOnUpdateMessageFactory : ICommandListSubmitCommandsOnUpdateMessageFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CommandListSubmitCommandsOnUpdateMessageFactory()
        {
        }

        public CommandListSubmitCommandsOnUpdateMessage Create(
            CommandList value)
        {
            CommandListSubmitCommandsOnUpdateMessage message = default;

            try
            {
                message = new CommandListSubmitCommandsOnUpdateMessage(
                    value);
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