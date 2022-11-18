namespace BeVelS.Physics.Collidables.Factories
{
    using System;

    using log4net;

    using BepuPhysics.Collidables;

    using BeVelS.Physics.Collidables.InterfacesFactories;

    internal sealed class SphereFactory : ISphereFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SphereFactory()
        {
        }

        public Sphere Create(
            float radius)
        {
            Sphere sphere = default;

            try
            {
                sphere = new Sphere(
                    radius: radius);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return sphere;
        }
    }
}