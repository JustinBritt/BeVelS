namespace BeVelS.ECS.Messages.Inputs.Windows.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Messages.Inputs.Windows.Factories;
    using BeVelS.ECS.Messages.Inputs.Windows.InterfacesAbstractFactories;
    using BeVelS.ECS.Messages.Inputs.Windows.InterfacesFactories;
    
    public sealed class InputsWindowsAbstractFactory : IInputsWindowsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InputsWindowsAbstractFactory()
        {
        }

        public IWin32InputEndMessageFactory CreateWin32InputEndMessageFactory()
        {
            IWin32InputEndMessageFactory factory = null;

            try
            {
                factory = new Win32InputEndMessageFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IWin32InputLockMouseMessageFactory CreateWin32InputLockMouseMessageFactory()
        {
            IWin32InputLockMouseMessageFactory factory = null;

            try
            {
                factory = new Win32InputLockMouseMessageFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IWin32InputStartMessageFactory CreateWin32InputStartMessageFactory()
        {
            IWin32InputStartMessageFactory factory = null;

            try
            {
                factory = new Win32InputStartMessageFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IWin32InputLockMouseMessageFactory CreateWin32InputUnlockMouseMessageFactory()
        {
            IWin32InputLockMouseMessageFactory factory = null;

            try
            {
                factory = new Win32InputLockMouseMessageFactory();
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