namespace BeVelS.ECS.Components.Hosts.Windows.InterfacesFactories
{
    using BeVelS.ECS.Components.Hosts.Windows.Structs;

    using BeVelS.Integration.Windows.Interfaces.Hosts;

    public interface IWin32HostComponentFactory
    {
        Win32HostComponent Create(
            IWin32Host value);
    }
}