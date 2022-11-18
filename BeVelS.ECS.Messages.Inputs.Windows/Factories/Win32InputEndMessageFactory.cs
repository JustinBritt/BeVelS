namespace BeVelS.ECS.Messages.Inputs.Windows.Factories
{
    using System;

    using log4net;

    using BeVelS.ECS.Messages.Inputs.Windows.InterfacesFactories;
    using BeVelS.ECS.Messages.Inputs.Windows.Structs;

    internal sealed class Win32InputEndMessageFactory : IWin32InputEndMessageFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Win32InputEndMessageFactory()
        {
        }

        public Win32InputEndMessage Create()
        {
            Win32InputEndMessage message = default;

            try
            {
                message = new Win32InputEndMessage();
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