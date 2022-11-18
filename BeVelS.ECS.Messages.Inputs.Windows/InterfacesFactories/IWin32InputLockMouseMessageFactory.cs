namespace BeVelS.ECS.Messages.Inputs.Windows.InterfacesFactories
{
    using BeVelS.ECS.Messages.Inputs.Windows.Structs;

    public interface IWin32InputLockMouseMessageFactory
    {
        Win32InputLockMouseMessage Create();
    }
}