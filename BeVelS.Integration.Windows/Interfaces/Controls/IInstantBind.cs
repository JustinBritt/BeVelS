namespace BeVelS.Integration.Windows.Interfaces.Controls
{
    using BeVelS.Integration.Windows.Interfaces.Inputs;

    public interface IInstantBind
    {
        bool WasTriggered(
            IWin32Input win32Input);
    }
}