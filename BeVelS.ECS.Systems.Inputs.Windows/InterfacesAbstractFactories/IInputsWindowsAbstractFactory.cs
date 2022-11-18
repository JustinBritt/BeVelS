namespace BeVelS.ECS.Systems.Inputs.Windows.InterfacesAbstractFactories
{
    using BeVelS.ECS.Systems.Inputs.Windows.InterfacesFactories;

    public interface IInputsWindowsAbstractFactory
    {
        IWin32InputSystemFactory CreateWin32InputSystemFactory();
    }
}