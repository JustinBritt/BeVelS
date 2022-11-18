namespace BeVelS.ECS.Systems.Inputs.Windows.InterfacesFactories
{
    using DefaultEcs;

    using BeVelS.ECS.Systems.Inputs.Windows.Interfaces;

    using BeVelS.Integration.Windows.Interfaces.Inputs;

    public interface IWin32InputSystemFactory
    {
        IWin32InputSystem Create(
            IWin32Input win32Input,
            World world);
    }
}