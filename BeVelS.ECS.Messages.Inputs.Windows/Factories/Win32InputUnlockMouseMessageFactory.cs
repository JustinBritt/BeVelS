namespace BeVelS.ECS.Messages.Inputs.Windows.Factories
{
    using System;

    using log4net;

    using BeVelS.ECS.Messages.Inputs.Windows.InterfacesFactories;
    using BeVelS.ECS.Messages.Inputs.Windows.Structs;

    internal sealed class Win32InputUnlockMouseMessageFactory : IWin32InputUnlockMouseMessageFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Win32InputUnlockMouseMessageFactory()
        {
        }

        public Win32InputUnlockMouseMessage Create()
        {
            Win32InputUnlockMouseMessage message = default;

            try
            {
                message = new Win32InputUnlockMouseMessage();
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