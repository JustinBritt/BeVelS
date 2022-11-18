namespace BeVelS.ECS.Systems.Inputs.Windows.Factories
{
    using System;

    using log4net;

    using DefaultEcs;

    using BeVelS.ECS.Systems.Inputs.Windows.Classes;
    using BeVelS.ECS.Systems.Inputs.Windows.Interfaces;
    using BeVelS.ECS.Systems.Inputs.Windows.InterfacesFactories;

    using BeVelS.Integration.Windows.Interfaces.Inputs;

    internal sealed class Win32InputSystemFactory : IWin32InputSystemFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Win32InputSystemFactory()
        {
        }

        public IWin32InputSystem Create(
            IWin32Input win32Input,
            World world)
        {
            IWin32InputSystem system = null;

            try
            {
                system = new Win32InputSystem(
                    win32Input,
                    world);
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