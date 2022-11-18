namespace BeVelS.Physics.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BepuPhysics;

    using BeVelS.Physics.InterfacesFactories;

    internal sealed class BodyVelocityFactory : IBodyVelocityFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BodyVelocity Create(
            Vector3 angularVelocity,
            Vector3 linearVelocity)
        {
            BodyVelocity bodyVelocity = default;

            try
            {
                bodyVelocity = new BodyVelocity();

                bodyVelocity.Angular = angularVelocity;

                bodyVelocity.Linear = linearVelocity;
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return bodyVelocity;
        }
    }
}