namespace BeVelS.ECS.Systems.CommandLists.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Systems.CommandLists.Factories;
    using BeVelS.ECS.Systems.CommandLists.InterfacesAbstractFactories;
    using BeVelS.ECS.Systems.CommandLists.InterfacesFactories;

    public sealed class CommandListsAbstractFactory : ICommandListsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CommandListsAbstractFactory()
        {
        }

        public ICommandListsSystemFactory CreateCommandListsSystemFactory()
        {
            ICommandListsSystemFactory factory = null;

            try
            {
                factory = new CommandListsSystemFactory();
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