namespace BeVelS.ECS.Systems.Inputs.Windows.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Systems.Inputs.Windows.Factories;
    using BeVelS.ECS.Systems.Inputs.Windows.InterfacesAbstractFactories;
    using BeVelS.ECS.Systems.Inputs.Windows.InterfacesFactories;

    public sealed class InputsWindowsAbstractFactory : IInputsWindowsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InputsWindowsAbstractFactory()
        {
        }

        public IWin32InputSystemFactory CreateWin32InputSystemFactory()
        {
            IWin32InputSystemFactory factory = null;

            try
            {
                factory = new Win32InputSystemFactory();
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