namespace BeVelS.Physics.Callbacks.Factories
{
    using System;

    using log4net;

    using BepuPhysics.Constraints;

    using BeVelS.Physics.Callbacks.InterfacesFactories;
    using BeVelS.Physics.Callbacks.Structs;
    
    internal sealed class NarrowPhaseCallbacksFactory : INarrowPhaseCallbacksFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public NarrowPhaseCallbacksFactory()
        {
        }

        public NarrowPhaseCallbacks Create()
        {
            NarrowPhaseCallbacks callbacks = default;

            try
            {
                callbacks = new NarrowPhaseCallbacks();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return callbacks;
        }

        public NarrowPhaseCallbacks Create(
            SpringSettings contactSpringiness,
            float maximumRecoveryVelocity = 2f,
            float frictionCoefficient = 1f)
        {
            NarrowPhaseCallbacks callbacks = default;

            try
            {
                callbacks = new NarrowPhaseCallbacks(
                    contactSpringiness: contactSpringiness,
                    maximumRecoveryVelocity: maximumRecoveryVelocity,
                    frictionCoefficient: frictionCoefficient);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return callbacks;
        }
    }
}