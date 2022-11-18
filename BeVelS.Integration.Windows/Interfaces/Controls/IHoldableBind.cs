namespace BeVelS.Integration.Windows.Interfaces.Controls
{
    using BeVelS.Integration.Windows.Interfaces.Inputs;

    public interface IHoldableBind
    {
        bool IsDown(
            IWin32Input win32Input);

        bool WasPushed(
            IWin32Input win32Input);
    }
}