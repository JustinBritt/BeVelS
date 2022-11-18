namespace BeVelS.Graphics.CommandLists.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.CommandLists.Factories;
    using BeVelS.Graphics.CommandLists.InterfacesAbstractFactories;
    using BeVelS.Graphics.CommandLists.InterfacesFactories;

    public sealed class CommandListsAbstractFactory : ICommandListsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CommandListsAbstractFactory()
        {
        }

        public ICommandListFactory CreateCommandListFactory()
        {
            ICommandListFactory factory = null;

            try
            {
                factory = new CommandListFactory();
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