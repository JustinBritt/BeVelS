namespace BeVelS.ECS.Systems.Controls.Windows.InterfacesFactories
{
    using DefaultEcs;

    using BeVelS.ECS.Messages.Cameras.InterfacesFactories;
    using BeVelS.ECS.Systems.Controls.Windows.Interfaces;

    using BeVelS.Integration.Windows.Interfaces.Controls;
    using BeVelS.Integration.Windows.InterfacesFactories.Controls;

    public interface IControlsSystemFactory
    {
        IControlsSystem Create(
            ICameraSetPositionMessageFactory cameraSetPositionMessageFactory,
            IControlsFactory controlsFactory,
            World world,
            IControls controls = null);
    }
}