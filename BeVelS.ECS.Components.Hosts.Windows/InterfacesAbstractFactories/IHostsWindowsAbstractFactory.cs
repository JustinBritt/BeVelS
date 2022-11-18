namespace BeVelS.ECS.Components.Hosts.Windows.InterfacesAbstractFactories
{
    using BeVelS.ECS.Components.Hosts.Windows.InterfacesFactories;

    public interface IHostsWindowsAbstractFactory
    {
        IWin32HostComponentFactory CreateWin32HostComponentFactory();
    }
}