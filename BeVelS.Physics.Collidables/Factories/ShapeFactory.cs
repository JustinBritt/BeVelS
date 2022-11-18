namespace BeVelS.Physics.Collidables.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BepuPhysics.Collidables;

    using BeVelS.Physics.Collidables.InterfacesFactories;

    internal sealed class ShapeFactory : IShapeFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ShapeFactory()
        {
        }

        public IShape Create(
            IBoxFactory boxFactory,
            float width,
            float height,
            float length)
        {
            IShape shape = null;

            try
            {
                shape = boxFactory.Create(
                    width: width,
                    height: height,
                    length: length);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return shape;
        }

        public IShape Create(
            ICapsuleFactory capsuleFactory,
            float radius,
            float length)
        {
            IShape shape = null;

            try
            {
                shape = capsuleFactory.Create(
                    radius: radius,
                    length: length);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return shape;
        }

        public IShape Create(
            ICylinderFactory cylinderFactory,
            float radius,
            float length)
        {
            IShape shape = null;

            try
            {
                shape = cylinderFactory.Create(
                    radius: radius,
                    length: length);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return shape;
        }

        public IShape Create(
            ISphereFactory sphereFactory,
            float radius)
        {
            IShape shape = null;

            try
            {
                shape = sphereFactory.Create(
                    radius: radius);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return shape;
        }

        public IShape Create(
            ITriangleFactory triangleFactory,
            Vector3 a,
            Vector3 b,
            Vector3 c)
        {
            IShape shape = null;

            try
            {
                shape = triangleFactory.Create(
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

            return shape;
        }
    }
}