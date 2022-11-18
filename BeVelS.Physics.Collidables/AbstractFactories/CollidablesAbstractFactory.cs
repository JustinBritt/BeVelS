namespace BeVelS.Physics.Collidables.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Physics.Collidables.Factories;
    using BeVelS.Physics.Collidables.InterfacesAbstractFactories;
    using BeVelS.Physics.Collidables.InterfacesFactories;

    public sealed class CollidablesAbstractFactory : ICollidablesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CollidablesAbstractFactory()
        {
        }

        public IBoxFactory CreateBoxFactory()
        {
            IBoxFactory factory = null;

            try
            {
                factory = new BoxFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICapsuleFactory CreateCapsuleFactory()
        {
            ICapsuleFactory factory = null;

            try
            {
                factory = new CapsuleFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICollidableDescriptionFactory CreateCollidableDescriptionFactory()
        {
            ICollidableDescriptionFactory factory = null;

            try
            {
                factory = new CollidableDescriptionFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICollidableReferenceFactory CreateCollidableReferenceFactory()
        {
            ICollidableReferenceFactory factory = null;

            try
            {
                factory = new CollidableReferenceFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConvexHullFactory CreateConvexHullFactory()
        {
            IConvexHullFactory factory = null;

            try
            {
                factory = new ConvexHullFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICylinderFactory CreateCylinderFactory()
        {
            ICylinderFactory factory = null;

            try
            {
                factory = new CylinderFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IMeshFactory CreateMeshFactory()
        {
            IMeshFactory factory = null;

            try
            {
                factory = new MeshFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IShapeFactory CreateShapeFactory()
        {
            IShapeFactory factory = null;

            try
            {
                factory = new ShapeFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISphereFactory CreateSphereFactory()
        {
            ISphereFactory factory = null;

            try
            {
                factory = new SphereFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITriangleFactory CreateTriangleFactory()
        {
            ITriangleFactory factory = null;

            try
            {
                factory = new TriangleFactory();
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