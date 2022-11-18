namespace BeVelS.ECS.Messages.CommandLists.Factories
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.ECS.Messages.CommandLists.InterfacesFactories;
    using BeVelS.ECS.Messages.CommandLists.Structs;

    internal sealed class CommandListSubmitCommandsMessageFactory : ICommandListSubmitCommandsMessageFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CommandListSubmitCommandsMessageFactory()
        {
        }

        public CommandListSubmitCommandsMessage Create(
            CommandList value)
        {
            CommandListSubmitCommandsMessage message = default;

            try
            {
                message = new CommandListSubmitCommandsMessage(
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