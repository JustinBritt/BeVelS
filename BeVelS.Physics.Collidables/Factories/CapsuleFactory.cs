namespace BeVelS.Physics.Collidables.Factories
{
    using System;

    using log4net;

    using BepuPhysics.Collidables;

    using BeVelS.Physics.Collidables.InterfacesFactories;

    internal sealed class CapsuleFactory : ICapsuleFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CapsuleFactory()
        {
        }

        public Capsule Create(
            float radius,
            float length)
        {
            Capsule capsule = default;

            try
            {
                capsule = new Capsule(
                    radius: radius,
                    length: length);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return capsule;
        }
    }
}