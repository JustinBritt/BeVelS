namespace BeVelS.Integration.Windows.Interfaces.Inputs
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Windows.Input;

    public interface IWin32Input : IDisposable
    {
        Vector2 MouseDelta { get; }

        bool MouseLocked { get; set; }

        Vector2 MousePosition { get; set; }

        float ScrolledDown { get; }

        float ScrolledUp { get; }

        List<char> TypedCharacters { get; }

        void End();

        bool IsDown(
            Key key);

        bool IsDown(
            MouseButton button);

        void Start();

        bool WasPushed(
            Key key);

        bool WasPushed(
            MouseButton button);
    }
}