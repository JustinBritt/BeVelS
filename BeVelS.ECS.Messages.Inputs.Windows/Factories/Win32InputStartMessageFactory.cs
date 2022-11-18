namespace BeVelS.ECS.Messages.Inputs.Windows.Factories
{
    using System;

    using log4net;

    using BeVelS.ECS.Messages.Inputs.Windows.InterfacesFactories;
    using BeVelS.ECS.Messages.Inputs.Windows.Structs;

    internal sealed class Win32InputStartMessageFactory : IWin32InputStartMessageFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Win32InputStartMessageFactory()
        {
        }

        public Win32InputStartMessage Create()
        {
            Win32InputStartMessage message = default;

            try
            {
                message = new Win32InputStartMessage();
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