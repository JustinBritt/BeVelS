namespace BeVelS.ECS.Components.Shapes.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Components.Shapes.Factories;
    using BeVelS.ECS.Components.Shapes.InterfacesAbstractFactories;
    using BeVelS.ECS.Components.Shapes.InterfacesFactories;

    public sealed class ShapesAbstractFactory : IShapesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ShapesAbstractFactory()
        {
        }

        public IBigCompoundInstanceComponentFactory CreateBigCompoundInstanceComponentFactory()
        {
            IBigCompoundInstanceComponentFactory factory = null;

            try
            {
                factory = new BigCompoundInstanceComponentFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IBoxInstanceComponentFactory CreateBoxInstanceComponentFactory()
        {
            IBoxInstanceComponentFactory factory = null;

            try
            {
                factory = new BoxInstanceComponentFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICapsuleInstanceComponentFactory CreateCapsuleInstanceComponentFactory()
        {
            ICapsuleInstanceComponentFactory factory = null;

            try
            {
                factory = new CapsuleInstanceComponentFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICompoundInstanceComponentFactory CreateCompoundInstanceComponentFactory()
        {
            ICompoundInstanceComponentFactory factory = null;

            try
            {
                factory = new CompoundInstanceComponentFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConvexHullInstanceComponentFactory CreateConvexHullInstanceComponentFactory()
        {
            IConvexHullInstanceComponentFactory factory = null;

            try
            {
                factory = new ConvexHullInstanceComponentFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICylinderInstanceComponentFactory CreateCylinderInstanceComponentFactory()
        {
            ICylinderInstanceComponentFactory factory = null;

            try
            {
                factory = new CylinderInstanceComponentFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IMeshInstanceComponentFactory CreateMeshInstanceComponentFactory()
        {
            IMeshInstanceComponentFactory factory = null;

            try
            {
                factory = new MeshInstanceComponentFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IShapeInstanceComponentFactory CreateShapeInstanceComponentFactory()
        {
            IShapeInstanceComponentFactory factory = null;

            try
            {
                factory = new ShapeInstanceComponentFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISphereInstanceComponentFactory CreateSphereInstanceComponentFactory()
        {
            ISphereInstanceComponentFactory factory = null;

            try
            {
                factory = new SphereInstanceComponentFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITriangleInstanceComponentFactory CreateTriangleInstanceComponentFactory()
        {
            ITriangleInstanceComponentFactory factory = null;

            try
            {
                factory = new TriangleInstanceComponentFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITShapeInstanceComponentFactory CreateTShapeInstanceComponentFactory()
        {
            ITShapeInstanceComponentFactory factory = null;

            try
            {
                factory = new TShapeInstanceComponentFactory();
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