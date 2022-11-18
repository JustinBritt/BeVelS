namespace BeVelS.ECS.Messages.Hosts.Windows.InterfacesAbstractFactories
{
    using BeVelS.ECS.Messages.Hosts.Windows.InterfacesFactories;

    public interface IHostsWindowsAbstractFactory
    {
        IWin32HostCloseMessageFactory CreateWin32HostCloseMessageFactory();
    }
}