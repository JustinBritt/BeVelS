namespace BeVelS.Physics.Callbacks.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Physics.Callbacks.Factories;
    using BeVelS.Physics.Callbacks.InterfacesAbstractFactories;
    using BeVelS.Physics.Callbacks.InterfacesFactories;

    public sealed class CallbacksAbstractFactory : ICallbacksAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CallbacksAbstractFactory()
        {
        }

        public INarrowPhaseCallbacksFactory CreateNarrowPhaseCallbacksFactory()
        {
            INarrowPhaseCallbacksFactory factory = null;

            try
            {
                factory = new NarrowPhaseCallbacksFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IPoseIntegratorCallbacksFactory CreatePoseIntegratorCallbacksFactory()
        {
            IPoseIntegratorCallbacksFactory factory = null;

            try
            {
                factory = new PoseIntegratorCallbacksFactory();
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