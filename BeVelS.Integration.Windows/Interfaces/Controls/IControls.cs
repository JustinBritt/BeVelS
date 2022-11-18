namespace BeVelS.Integration.Windows.Interfaces.Controls
{
    public interface IControls
    {
        float CameraFastMoveSpeed { get; set; }

        float CameraMoveSpeed { get; set; }

        float CameraSlowMoveSpeed { get; set; }

        IInstantBind Exit { get; set; }

        IInstantBind LockMouse { get; set; }

        float MouseSensitivity { get; set; }

        IHoldableBind MoveBackward { get; set; }

        IHoldableBind MoveDown { get; set; }

        IInstantBind MoveFaster { get; set; }

        IHoldableBind MoveForward { get; set; }

        IHoldableBind MoveLeft { get; set; }

        IHoldableBind MoveRight { get; set; }

        IInstantBind MoveSlower { get; set; }

        IHoldableBind MoveUp { get; set; }
    }
}