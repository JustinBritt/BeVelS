namespace BeVelS.ECS.Components.Hosts.Windows.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Components.Hosts.Windows.Factories;
    using BeVelS.ECS.Components.Hosts.Windows.InterfacesAbstractFactories;
    using BeVelS.ECS.Components.Hosts.Windows.InterfacesFactories;

    public sealed class HostsWindowsAbstractFactory : IHostsWindowsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HostsWindowsAbstractFactory()
        {
        }

        public IWin32HostComponentFactory CreateWin32HostComponentFactory()
        {
            IWin32HostComponentFactory factory = null;

            try
            {
                factory = new Win32HostComponentFactory();
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