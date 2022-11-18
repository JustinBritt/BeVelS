namespace BeVelS.ECS.Components.Inputs.Windows.InterfacesAbstractFactories
{
    using BeVelS.ECS.Components.Inputs.Windows.InterfacesFactories;

    public interface IInputsWindowsAbstractFactory
    {
        IWin32InputComponentFactory CreateWin32InputComponentFactory();
    }
}