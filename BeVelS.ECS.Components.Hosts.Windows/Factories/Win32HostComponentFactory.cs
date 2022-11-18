namespace BeVelS.ECS.Components.Hosts.Windows.Factories
{
    using System;

    using log4net;

    using BeVelS.ECS.Components.Hosts.Windows.InterfacesFactories;
    using BeVelS.ECS.Components.Hosts.Windows.Structs;

    using BeVelS.Integration.Windows.Interfaces.Hosts;

    internal sealed class Win32HostComponentFactory : IWin32HostComponentFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Win32HostComponentFactory()
        {
        }

        public Win32HostComponent Create(
            IWin32Host value)
        {
            Win32HostComponent component = default;

            try
            {
                component = new Win32HostComponent(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return component;
        }
    }
}