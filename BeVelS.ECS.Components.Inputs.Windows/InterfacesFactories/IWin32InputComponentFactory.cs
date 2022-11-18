namespace BeVelS.ECS.Components.Inputs.Windows.InterfacesFactories
{
    using BeVelS.ECS.Components.Inputs.Windows.Structs;

    using BeVelS.Integration.Windows.Interfaces.Inputs;

    public interface IWin32InputComponentFactory
    {
        Win32InputComponent Create(
            IWin32Input value);
    }
}