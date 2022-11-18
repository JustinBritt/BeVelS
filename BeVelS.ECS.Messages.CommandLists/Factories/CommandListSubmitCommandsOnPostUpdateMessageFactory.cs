namespace BeVelS.ECS.Messages.CommandLists.Factories
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.ECS.Messages.CommandLists.InterfacesFactories;
    using BeVelS.ECS.Messages.CommandLists.Structs;

    internal sealed class CommandListSubmitCommandsOnPostUpdateMessageFactory : ICommandListSubmitCommandsOnPostUpdateMessageFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CommandListSubmitCommandsOnPostUpdateMessageFactory()
        {
        }

        public CommandListSubmitCommandsOnPostUpdateMessage Create(
            CommandList value)
        {
            CommandListSubmitCommandsOnPostUpdateMessage message = default;

            try
            {
                message = new CommandListSubmitCommandsOnPostUpdateMessage(
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