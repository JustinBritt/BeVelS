namespace BeVelS.Graphics.Buffers.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.Buffers.Factories;
    using BeVelS.Graphics.Buffers.Factories.Descriptions;
    using BeVelS.Graphics.Buffers.Factories.FragmentConstants;
    using BeVelS.Graphics.Buffers.Factories.Instances;
    using BeVelS.Graphics.Buffers.Factories.ShapeInstances;
    using BeVelS.Graphics.Buffers.Factories.VertexConstants;
    using BeVelS.Graphics.Buffers.InterfacesAbstractFactories;
    using BeVelS.Graphics.Buffers.InterfacesFactories;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Buffers.InterfacesFactories.FragmentConstants;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Instances;
    using BeVelS.Graphics.Buffers.InterfacesFactories.ShapeInstances;
    using BeVelS.Graphics.Buffers.InterfacesFactories.VertexConstants;

    public sealed class BuffersAbstractFactory : IBuffersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BuffersAbstractFactory()
        {
        }

        public IBackgroundVertexConstantsBufferFactory CreateBackgroundVertexConstantsBufferFactory()
        {
            IBackgroundVertexConstantsBufferFactory factory = null;

            try
            {
                factory = new BackgroundVertexConstantsBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IBoxInstancesBufferFactory CreateBoxInstancesBufferFactory()
        {
            IBoxInstancesBufferFactory factory = null;

            try
            {
                factory = new BoxInstancesBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IBoxVertexConstantsBufferFactory CreateBoxVertexConstantsBufferFactory()
        {
            IBoxVertexConstantsBufferFactory factory = null;

            try
            {
                factory = new BoxVertexConstantsBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IBufferDescriptionFactory CreateBufferDescriptionFactory()
        {
            IBufferDescriptionFactory factory = null;

            try
            {
                factory = new BufferDescriptionFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICapsuleFragmentConstantsBufferFactory CreateCapsuleFragmentConstantsBufferFactory()
        {
            ICapsuleFragmentConstantsBufferFactory factory = null;

            try
            {
                factory = new CapsuleFragmentConstantsBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICapsuleInstancesBufferFactory CreateCapsuleInstancesBufferFactory()
        {
            ICapsuleInstancesBufferFactory factory = null;

            try
            {
                factory = new CapsuleInstancesBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICapsuleVertexConstantsBufferFactory CreateCapsuleVertexConstantsBufferFactory()
        {
            ICapsuleVertexConstantsBufferFactory factory = null;

            try
            {
                factory = new CapsuleVertexConstantsBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstantsBufferFactory CreateConstantsBufferFactory()
        {
            IConstantsBufferFactory factory = null;

            try
            {
                factory = new ConstantsBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICylinderFragmentConstantsBufferFactory CreateCylinderFragmentConstantsBufferFactory()
        {
            ICylinderFragmentConstantsBufferFactory factory = null;

            try
            {
                factory = new CylinderFragmentConstantsBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICylinderInstancesBufferFactory CreateCylinderInstancesBufferFactory()
        {
            ICylinderInstancesBufferFactory factory = null;

            try
            {
                factory = new CylinderInstancesBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICylinderVertexConstantsBufferFactory CreateCylinderVertexConstantsBufferFactory()
        {
            ICylinderVertexConstantsBufferFactory factory = null;

            try
            {
                factory = new CylinderVertexConstantsBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IGlyphInstancesBufferFactory CreateGlyphInstancesBufferFactory()
        {
            IGlyphInstancesBufferFactory factory = null;

            try
            {
                factory = new GlyphInstancesBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IGlyphVertexConstantsBufferFactory CreateGlyphVertexConstantsBufferFactory()
        {
            IGlyphVertexConstantsBufferFactory factory = null;

            try
            {
                factory = new GlyphVertexConstantsBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IHTMLInstancesBufferFactory CreateHTMLInstancesBufferFactory()
        {
            IHTMLInstancesBufferFactory factory = null;

            try
            {
                factory = new HTMLInstancesBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IHTMLVertexConstantsBufferFactory CreateHTMLVertexConstantsBufferFactory()
        {
            IHTMLVertexConstantsBufferFactory factory = null;

            try
            {
                factory = new HTMLVertexConstantsBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IImageInstancesBufferFactory CreateImageInstancesBufferFactory()
        {
            IImageInstancesBufferFactory factory = null;

            try
            {
                factory = new ImageInstancesBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IImageVertexConstantsBufferFactory CreateImageVertexConstantsBufferFactory()
        {
            IImageVertexConstantsBufferFactory factory = null;

            try
            {
                factory = new ImageVertexConstantsBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IIndexBufferFactory CreateIndexBufferFactory()
        {
            IIndexBufferFactory factory = null;

            try
            {
                factory = new IndexBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IInstancesBufferFactory CreateInstancesBufferFactory()
        {
            IInstancesBufferFactory factory = null;

            try
            {
                factory = new InstancesBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ILineInstancesBufferFactory CreateLineInstancesBufferFactory()
        {
            ILineInstancesBufferFactory factory = null;

            try
            {
                factory = new LineInstancesBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ILineVertexConstantsBufferFactory CreateLineVertexConstantsBufferFactory()
        {
            ILineVertexConstantsBufferFactory factory = null;

            try
            {
                factory = new LineVertexConstantsBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IMeshInstancesBufferFactory CreateMeshInstancesBufferFactory()
        {
            IMeshInstancesBufferFactory factory = null;

            try
            {
                factory = new MeshInstancesBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IMeshVertexConstantsBufferFactory CreateMeshVertexConstantsBufferFactory()
        {
            IMeshVertexConstantsBufferFactory factory = null;

            try
            {
                factory = new MeshVertexConstantsBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IShapeInstancesBufferFactory CreateShapeInstancesBufferFactory()
        {
            IShapeInstancesBufferFactory factory = null;

            try
            {
                factory = new ShapeInstancesBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISphereFragmentConstantsBufferFactory CreateSphereFragmentConstantsBufferFactory()
        {
            ISphereFragmentConstantsBufferFactory factory = null;

            try
            {
                factory = new SphereFragmentConstantsBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISphereInstancesBufferFactory CreateSphereInstancesBufferFactory()
        {
            ISphereInstancesBufferFactory factory = null;

            try
            {
                factory = new SphereInstancesBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISphereVertexConstantsBufferFactory CreateSphereVertexConstantsBufferFactory()
        {
            ISphereVertexConstantsBufferFactory factory = null;

            try
            {
                factory = new SphereVertexConstantsBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITriangleInstancesBufferFactory CreateTriangleInstancesBufferFactory()
        {
            ITriangleInstancesBufferFactory factory = null;

            try
            {
                factory = new TriangleInstancesBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITriangleVertexConstantsBufferFactory CreateTriangleVertexConstantsBufferFactory()
        {
            ITriangleVertexConstantsBufferFactory factory = null;

            try
            {
                factory = new TriangleVertexConstantsBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IUILineInstancesBufferFactory CreateUILineInstancesBufferFactory()
        {
            IUILineInstancesBufferFactory factory = null;

            try
            {
                factory = new UILineInstancesBufferFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IUILineVertexConstantsBufferFactory CreateUILineVertexConstantsBufferFactory()
        {
            IUILineVertexConstantsBufferFactory factory = null;

            try
            {
                factory = new UILineVertexConstantsBufferFactory();
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