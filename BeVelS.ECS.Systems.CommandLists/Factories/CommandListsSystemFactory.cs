namespace BeVelS.ECS.Systems.CommandLists.Factories
{
    using System;

    using log4net;

    using DefaultEcs;

    using BeVelS.ECS.Systems.CommandLists.Classes;
    using BeVelS.ECS.Systems.CommandLists.Interfaces;
    using BeVelS.ECS.Systems.CommandLists.InterfacesFactories;

    internal sealed class CommandListsSystemFactory : ICommandListsSystemFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CommandListsSystemFactory()
        {
        }

        public ICommandListsSystem Create(
            World world)
        {
            ICommandListsSystem system = null;

            try
            {
                system = new CommandListsSystem(
                    world);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return system;
        }
    }
}