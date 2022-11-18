namespace BeVelS.ECS.Systems.Controls.Windows.Factories
{
    using System;

    using log4net;

    using DefaultEcs;

    using BeVelS.ECS.Messages.Cameras.InterfacesFactories;
    using BeVelS.ECS.Systems.Controls.Windows.Classes;
    using BeVelS.ECS.Systems.Controls.Windows.Interfaces;
    using BeVelS.ECS.Systems.Controls.Windows.InterfacesFactories;
    
    using BeVelS.Integration.Windows.Interfaces.Controls;
    using BeVelS.Integration.Windows.InterfacesFactories.Controls;

    internal sealed class ControlsSystemFactory : IControlsSystemFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ControlsSystemFactory()
        {
        }

        public IControlsSystem Create(
            ICameraSetPositionMessageFactory cameraSetPositionMessageFactory,
            IControlsFactory controlsFactory,
            World world,
            IControls controls = null)
        {
            IControlsSystem system = null;

            try
            {
                system = new ControlsSystem(
                    cameraSetPositionMessageFactory,
                    controlsFactory,
                    world,
                    controls);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return system;
        }
    }
}