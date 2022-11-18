namespace BeVelS.Physics.Collidables.Factories
{
    using System;

    using log4net;

    using BepuPhysics.Collidables;

    using BeVelS.Physics.Collidables.InterfacesFactories;

    internal sealed class CylinderFactory : ICylinderFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CylinderFactory()
        {
        }

        public Cylinder Create(
            float radius,
            float length)
        {
            Cylinder cylinder = default;

            try
            {
                cylinder = new Cylinder(
                    radius: radius,
                    length: length);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return cylinder;
        }
    }
}