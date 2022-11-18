namespace BeVelS.ECS.Messages.Inputs.Windows.InterfacesFactories
{
    using BeVelS.ECS.Messages.Inputs.Windows.Structs;

    public interface IWin32InputStartMessageFactory
    {
        Win32InputStartMessage Create();
    }
}