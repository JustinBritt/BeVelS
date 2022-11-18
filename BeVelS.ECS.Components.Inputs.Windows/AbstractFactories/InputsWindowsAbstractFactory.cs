namespace BeVelS.ECS.Components.Inputs.Windows.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Components.Inputs.Windows.Factories;
    using BeVelS.ECS.Components.Inputs.Windows.InterfacesAbstractFactories;
    using BeVelS.ECS.Components.Inputs.Windows.InterfacesFactories;

    public sealed class InputsWindowsAbstractFactory : IInputsWindowsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InputsWindowsAbstractFactory()
        {
        }

        public IWin32InputComponentFactory CreateWin32InputComponentFactory()
        {
            IWin32InputComponentFactory factory = null;

            try
            {
                factory = new Win32InputComponentFactory();
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