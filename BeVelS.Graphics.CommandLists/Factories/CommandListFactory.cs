namespace BeVelS.Graphics.CommandLists.Factories
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.CommandLists.InterfacesFactories;

    internal sealed class CommandListFactory : ICommandListFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CommandListFactory()
        {
        }

        public CommandList Create(
            GraphicsDevice graphicsDevice)
        {
            CommandList commandList = null;

            try
            {
                commandList = graphicsDevice.ResourceFactory.CreateCommandList();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return commandList;
        }

        public CommandList Create(
            GraphicsDevice graphicsDevice,
            string name)
        {
            CommandList commandList = null;

            try
            {
                commandList = graphicsDevice.ResourceFactory.CreateCommandList();

                commandList.Name = name;
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return commandList;
        }
    }
}