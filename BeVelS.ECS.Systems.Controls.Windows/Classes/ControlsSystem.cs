namespace BeVelS.ECS.Systems.Controls.Windows.Classes
{
    using System.Numerics;

    using DefaultEcs;

    using BeVelS.ECS.Components.Cameras.Extensions;
    using BeVelS.ECS.Components.Hosts.Windows.Extensions;
    using BeVelS.ECS.Components.Inputs.Windows.Extensions;
    using BeVelS.ECS.Messages.Cameras.InterfacesFactories;
    using BeVelS.ECS.Messages.Cameras.Structs;
    using BeVelS.ECS.Messages.Hosts.Windows.Structs;
    using BeVelS.ECS.Messages.Inputs.Windows.Structs;
    using BeVelS.ECS.Systems.Controls.Windows.Interfaces;

    using BeVelS.Graphics.Cameras.Enums;
    using BeVelS.Graphics.Cameras.Interfaces;

    using BeVelS.Integration.Windows.Interfaces.Controls;
    using BeVelS.Integration.Windows.Interfaces.Hosts;
    using BeVelS.Integration.Windows.Interfaces.Inputs;
    using BeVelS.Integration.Windows.InterfacesFactories.Controls;

    internal sealed class ControlsSystem : IControlsSystem
    {
        public ControlsSystem(
            ICameraSetPositionMessageFactory cameraSetPositionMessageFactory,
            IControlsFactory controlsFactory,
            World world,
            IControls controls = null)
        {
            this.CameraSetPositionMessageFactory = cameraSetPositionMessageFactory;

            this.World = world;

            this.World.Subscribe(
                this);

            if (controls == null)
            {
                this.Controls = controlsFactory.CreateDefault();
            }
        }

        private ICameraSetPositionMessageFactory CameraSetPositionMessageFactory { get; }

        private CameraMoveSpeedState CameraSpeedState { get; set; }

        private IControls Controls { get; }

        public bool IsEnabled { get; set; }

        private World World { get; }

        public void Update(
            float state)
        {
            if (this.IsEnabled)
            {
                ICamera camera = this.World.GetCameraLast();

                IWin32Host win32Host = this.World.GetWin32HostLast();

                IWin32Input win32Input = this.World.GetWin32InputLast();

                if (win32Host.Focused)
                {
                    if (this.Controls.Exit.WasTriggered(win32Input))
                    {
                        this.World.Publish<Win32HostCloseMessage>(
                            default);

                        return;
                    }

                    if (this.Controls.MoveFaster.WasTriggered(win32Input))
                    {
                        switch (this.CameraSpeedState)
                        {
                            case CameraMoveSpeedState.Slow:
                                this.CameraSpeedState = CameraMoveSpeedState.Regular;
                                break;
                            case CameraMoveSpeedState.Regular:
                                this.CameraSpeedState = CameraMoveSpeedState.Fast;
                                break;
                        }
                    }

                    if (this.Controls.MoveSlower.WasTriggered(win32Input))
                    {
                        switch (this.CameraSpeedState)
                        {
                            case CameraMoveSpeedState.Regular:
                                this.CameraSpeedState = CameraMoveSpeedState.Slow;
                                break;
                            case CameraMoveSpeedState.Fast:
                                this.CameraSpeedState = CameraMoveSpeedState.Regular;
                                break;
                        }
                    }

                    Vector3 cameraOffset = default;

                    if (this.Controls.MoveForward.IsDown(win32Input))
                        cameraOffset += camera.Forward;
                    if (this.Controls.MoveBackward.IsDown(win32Input))
                        cameraOffset += camera.Backward;
                    if (this.Controls.MoveLeft.IsDown(win32Input))
                        cameraOffset += camera.Left;
                    if (this.Controls.MoveRight.IsDown(win32Input))
                        cameraOffset += camera.Right;
                    if (this.Controls.MoveUp.IsDown(win32Input))
                        cameraOffset += camera.Up;
                    if (this.Controls.MoveDown.IsDown(win32Input))
                        cameraOffset += camera.Down;

                    float length = cameraOffset.Length();

                    if (length > 1e-7f)
                    {
                        float cameraMoveSpeed = this.CameraSpeedState switch
                        {
                            CameraMoveSpeedState.Slow => this.Controls.CameraSlowMoveSpeed,

                            CameraMoveSpeedState.Regular => this.Controls.CameraMoveSpeed,

                            CameraMoveSpeedState.Fast => this.Controls.CameraFastMoveSpeed,

                            _ => this.Controls.CameraMoveSpeed
                        };

                        cameraOffset *= state * cameraMoveSpeed / length;
                    }
                    else
                    {
                        cameraOffset = default;
                    }

                    this.World.Publish<CameraSetPositionMessage>(
                        this.CameraSetPositionMessageFactory.Create(
                            camera.Position + cameraOffset));
                }
                else
                {
                    this.World.Publish<Win32InputUnlockMouseMessage>(
                        default);
                }
            }
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;
            }
        }
    }
}