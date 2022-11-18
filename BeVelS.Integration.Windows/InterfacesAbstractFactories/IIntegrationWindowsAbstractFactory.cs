namespace BeVelS.Integration.Windows.InterfacesAbstractFactories
{
    using BeVelS.Integration.Windows.InterfacesFactories.Controls;
    using BeVelS.Integration.Windows.InterfacesFactories.Hosts;
    using BeVelS.Integration.Windows.InterfacesFactories.Inputs;

    public interface IIntegrationWindowsAbstractFactory
    {
        IControlsFactory CreateControlsFactory();

        IHoldableBindFactory CreateHoldableBindFactory();

        IInstantBindFactory CreateInstantBindFactory();

        IWin32HostFactory CreateWin32HostFactory();

        IWin32InputFactory CreateWin32InputFactory();
    }
}