namespace BeVelS.ECS.Systems.Hosts.Windows.InterfacesAbstractFactories
{
    using BeVelS.ECS.Systems.Hosts.Windows.InterfacesFactories;

    public interface IHostsWindowsAbstractFactory
    {
        IWin32HostSystemFactory CreateWin32HostSystemFactory();
    }
}