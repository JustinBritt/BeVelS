namespace BeVelS.Integration.Windows.Interfaces.Hosts
{
    using System;
    using System.Numerics;
    using System.Windows.Interop;
    using System.Windows.Media;
    using System.Windows.Threading;

    public interface IWin32Host
    {
        Dispatcher Dispatcher { get; }

        bool Focused { get; }

        HwndHost HwndHost { get; }

        Vector2 Resolution { get; }

        void Close();

        IntPtr GetHandle();

        Vector2 GetNormalizedMousePosition(
            Vector2 mousePosition,
            Vector2 resolution);

        void HookWndProc(
            Visual visual);
    }
}