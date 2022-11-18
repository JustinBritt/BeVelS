namespace BeVelS.Integration.Windows.InterfacesFactories.Inputs
{
    using BeVelS.Integration.Windows.Interfaces.Hosts;
    using BeVelS.Integration.Windows.Interfaces.Inputs;

    public interface IWin32InputFactory
    {
        IWin32Input Create(
            IWin32Host win32Host);
    }
}