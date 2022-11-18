namespace BeVelS.ECS.Messages.CommandLists.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Messages.CommandLists.Factories;
    using BeVelS.ECS.Messages.CommandLists.InterfacesAbstractFactories;
    using BeVelS.ECS.Messages.CommandLists.InterfacesFactories;

    public sealed class CommandListsAbstractFactory : ICommandListsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CommandListsAbstractFactory()
        {
        }

        public ICommandListSubmitCommandsMessageFactory CreateCommandListSubmitCommandsMessageFactory()
        {
            ICommandListSubmitCommandsMessageFactory factory = null;

            try
            {
                factory = new CommandListSubmitCommandsMessageFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICommandListSubmitCommandsOnPostUpdateMessageFactory CreateCommandListSubmitCommandsOnPostUpdateMessageFactory()
        {
            ICommandListSubmitCommandsOnPostUpdateMessageFactory factory = null;

            try
            {
                factory = new CommandListSubmitCommandsOnPostUpdateMessageFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICommandListSubmitCommandsOnUpdateMessageFactory CreateCommandListSubmitCommandsOnUpdateMessageFactory()
        {
            ICommandListSubmitCommandsOnUpdateMessageFactory factory = null;

            try
            {
                factory = new CommandListSubmitCommandsOnUpdateMessageFactory();
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