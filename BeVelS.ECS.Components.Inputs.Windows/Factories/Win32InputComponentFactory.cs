namespace BeVelS.ECS.Components.Inputs.Windows.Factories
{
    using System;

    using log4net;

    using BeVelS.ECS.Components.Inputs.Windows.InterfacesFactories;
    using BeVelS.ECS.Components.Inputs.Windows.Structs;

    using BeVelS.Integration.Windows.Interfaces.Inputs;

    internal sealed class Win32InputComponentFactory : IWin32InputComponentFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Win32InputComponentFactory()
        {
        }

        public Win32InputComponent Create(
            IWin32Input value)
        {
            Win32InputComponent component = default;

            try
            {
                component = new Win32InputComponent(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return component;
        }
    }
}