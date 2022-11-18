namespace BeVelS.ECS.Messages.Inputs.Windows.InterfacesAbstractFactories
{
    using BeVelS.ECS.Messages.Inputs.Windows.InterfacesFactories;

    public interface IInputsWindowsAbstractFactory
    {
        IWin32InputEndMessageFactory CreateWin32InputEndMessageFactory();

        IWin32InputLockMouseMessageFactory CreateWin32InputLockMouseMessageFactory();

        IWin32InputStartMessageFactory CreateWin32InputStartMessageFactory();

        IWin32InputLockMouseMessageFactory CreateWin32InputUnlockMouseMessageFactory();
    }
}