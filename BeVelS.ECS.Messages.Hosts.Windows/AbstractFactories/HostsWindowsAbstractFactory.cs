namespace BeVelS.ECS.Messages.Hosts.Windows.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Messages.Hosts.Windows.Factories;
    using BeVelS.ECS.Messages.Hosts.Windows.InterfacesAbstractFactories;
    using BeVelS.ECS.Messages.Hosts.Windows.InterfacesFactories;

    public sealed class HostsWindowsAbstractFactory : IHostsWindowsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HostsWindowsAbstractFactory()
        {
        }

        public IWin32HostCloseMessageFactory CreateWin32HostCloseMessageFactory()
        {
            IWin32HostCloseMessageFactory factory = null;

            try
            {
                factory = new Win32HostCloseMessageFactory();
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