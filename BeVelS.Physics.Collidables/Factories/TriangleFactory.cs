namespace BeVelS.Physics.Collidables.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BepuPhysics.Collidables;

    using BeVelS.Physics.Collidables.InterfacesFactories;

    internal sealed class TriangleFactory : ITriangleFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TriangleFactory()
        {
        }

        public Triangle Create(
            Vector3 a, 
            Vector3 b, 
            Vector3 c)
        {
            Triangle triangle = default;

            try
            {
                triangle = new Triangle(
                    a: a,
                    b: b,
                    c: c);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return triangle;
        }
    }
}