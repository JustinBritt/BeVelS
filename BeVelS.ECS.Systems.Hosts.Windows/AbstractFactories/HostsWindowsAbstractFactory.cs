namespace BeVelS.ECS.Systems.Hosts.Windows.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Systems.Hosts.Windows.Factories;
    using BeVelS.ECS.Systems.Hosts.Windows.InterfacesAbstractFactories;
    using BeVelS.ECS.Systems.Hosts.Windows.InterfacesFactories;

    public sealed class HostsWindowsAbstractFactory : IHostsWindowsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HostsWindowsAbstractFactory()
        {
        }

        public IWin32HostSystemFactory CreateWin32HostSystemFactory()
        {
            IWin32HostSystemFactory factory = null;

            try
            {
                factory = new Win32HostSystemFactory();
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