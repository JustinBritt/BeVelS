namespace BeVelS.Graphics.Shapes.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.Shapes.Factories;
    using BeVelS.Graphics.Shapes.InterfacesAbstractFactories;
    using BeVelS.Graphics.Shapes.InterfacesFactories;

    public sealed class ShapesAbstractFactory : IShapesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ShapesAbstractFactory()
        {
        }

        public IBigCompoundInstanceFactory CreateBigCompoundInstanceFactory()
        {
            IBigCompoundInstanceFactory factory = null;

            try
            {
                factory = new BigCompoundInstanceFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IBoxInstanceFactory CreateBoxInstanceFactory()
        {
            IBoxInstanceFactory factory = null;

            try
            {
                factory = new BoxInstanceFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICapsuleInstanceFactory CreateCapsuleInstanceFactory()
        {
            ICapsuleInstanceFactory factory = null;

            try
            {
                factory = new CapsuleInstanceFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICompoundInstanceFactory CreateCompoundInstanceFactory()
        {
            ICompoundInstanceFactory factory = null;

            try
            {
                factory = new CompoundInstanceFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConvexHullInstanceFactory CreateConvexHullInstanceFactory()
        {
            IConvexHullInstanceFactory factory = null;

            try
            {
                factory = new ConvexHullInstanceFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICylinderInstanceFactory CreateCylinderInstanceFactory()
        {
            ICylinderInstanceFactory factory = null;

            try
            {
                factory = new CylinderInstanceFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IMeshInstanceFactory CreateMeshInstanceFactory()
        {
            IMeshInstanceFactory factory = null;

            try
            {
                factory = new MeshInstanceFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IShapeInstanceFactory CreateShapeInstanceFactory()
        {
            IShapeInstanceFactory factory = null;

            try
            {
                factory = new ShapeInstanceFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISphereInstanceFactory CreateSphereInstanceFactory()
        {
            ISphereInstanceFactory factory = null;

            try
            {
                factory = new SphereInstanceFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITriangleInstanceFactory CreateTriangleInstanceFactory()
        {
            ITriangleInstanceFactory factory = null;

            try
            {
                factory = new TriangleInstanceFactory();
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