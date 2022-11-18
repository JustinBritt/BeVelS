namespace BeVelS.ECS.Messages.Inputs.Windows.Factories
{
    using System;

    using log4net;

    using BeVelS.ECS.Messages.Inputs.Windows.InterfacesFactories;
    using BeVelS.ECS.Messages.Inputs.Windows.Structs;

    internal sealed class Win32InputLockMouseMessageFactory : IWin32InputLockMouseMessageFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Win32InputLockMouseMessageFactory()
        {
        }

        public Win32InputLockMouseMessage Create()
        {
            Win32InputLockMouseMessage message = default;

            try
            {
                message = new Win32InputLockMouseMessage();
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