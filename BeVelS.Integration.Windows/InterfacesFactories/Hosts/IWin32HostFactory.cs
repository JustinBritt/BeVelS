namespace BeVelS.Integration.Windows.InterfacesFactories.Hosts
{
    using BeVelS.Integration.Windows.Interfaces.Hosts;

    public interface IWin32HostFactory
    {
        IWin32Host Create();
    }
}