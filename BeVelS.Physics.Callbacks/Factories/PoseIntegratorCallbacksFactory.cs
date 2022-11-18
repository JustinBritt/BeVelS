namespace BeVelS.Physics.Callbacks.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BeVelS.Physics.Callbacks.InterfacesFactories;
    using BeVelS.Physics.Callbacks.Structs;

    internal sealed class PoseIntegratorCallbacksFactory : IPoseIntegratorCallbacksFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PoseIntegratorCallbacksFactory()
        {
        }

        public PoseIntegratorCallbacks Create(
            Vector3 gravity,
            float linearDamping = .03f,
            float angularDamping = .03f)
        {
            PoseIntegratorCallbacks callbacks = default;

            try
            {
                callbacks = new PoseIntegratorCallbacks(
                    gravity: gravity,
                    linearDamping: linearDamping,
                    angularDamping: angularDamping);
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