namespace BeVelS.ECS.Systems.Hosts.Windows.InterfacesFactories
{
    using DefaultEcs;

    using BeVelS.ECS.Systems.Hosts.Windows.Interfaces;

    using BeVelS.Integration.Windows.Interfaces.Hosts;

    public interface IWin32HostSystemFactory
    {
        IWin32HostSystem Create(
            IWin32Host win32Host,
            World world);
    }
}