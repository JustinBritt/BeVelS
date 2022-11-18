namespace BeVelS.ECS.Messages.Hosts.Windows.InterfacesFactories
{
    using BeVelS.ECS.Messages.Hosts.Windows.Structs;

    public interface IWin32HostCloseMessageFactory
    {
        Win32HostCloseMessage Create();
    }
}