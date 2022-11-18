namespace BeVelS.ECS.Systems.Controls.Windows.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Systems.Controls.Windows.Factories;
    using BeVelS.ECS.Systems.Controls.Windows.InterfacesAbstractFactories;
    using BeVelS.ECS.Systems.Controls.Windows.InterfacesFactories;

    public sealed class ControlsWindowsAbstractFactory : IControlsWindowsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ControlsWindowsAbstractFactory()
        {
        }

        public IControlsSystemFactory CreateControlsSystemFactory()
        {
            IControlsSystemFactory factory = null;

            try
            {
                factory = new ControlsSystemFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}