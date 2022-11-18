namespace BeVelS.ECS.Messages.Hosts.Windows.Factories
{
    using System;

    using log4net;

    using BeVelS.ECS.Messages.Hosts.Windows.InterfacesFactories;
    using BeVelS.ECS.Messages.Hosts.Windows.Structs;

    internal sealed class Win32HostCloseMessageFactory : IWin32HostCloseMessageFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Win32HostCloseMessageFactory()
        {
        }

        public Win32HostCloseMessage Create()
        {
            Win32HostCloseMessage message = default;

            try
            {
                message = new Win32HostCloseMessage();
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