namespace BeVelS.ECS.Systems.Hosts.Windows.Factories
{
    using System;

    using log4net;

    using DefaultEcs;

    using BeVelS.ECS.Systems.Hosts.Windows.Classes;
    using BeVelS.ECS.Systems.Hosts.Windows.Interfaces;
    using BeVelS.ECS.Systems.Hosts.Windows.InterfacesFactories;

    using BeVelS.Integration.Windows.Interfaces.Hosts;

    internal sealed class Win32HostSystemFactory : IWin32HostSystemFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Win32HostSystemFactory()
        {
        }

        public IWin32HostSystem Create(
            IWin32Host win32Host,
            World world)
        {
            IWin32HostSystem system = null;

            try
            {
                system = new Win32HostSystem(
                    win32Host,
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