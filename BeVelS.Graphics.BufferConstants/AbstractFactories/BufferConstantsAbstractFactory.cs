namespace BeVelS.Graphics.BufferConstants.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.BufferConstants.Factories.FragmentConstants;
    using BeVelS.Graphics.BufferConstants.Factories.VertexConstants;
    using BeVelS.Graphics.BufferConstants.InterfacesAbstractFactories;
    using BeVelS.Graphics.BufferConstants.InterfacesFactories.FragmentConstants;
    using BeVelS.Graphics.BufferConstants.InterfacesFactories.VertexConstants;

    public sealed class BufferConstantsAbstractFactory : IBufferConstantsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BufferConstantsAbstractFactory()
        {
        }

        public IBoxVertexConstantsFactory CreateBoxVertexConstantsFactory()
        {
            IBoxVertexConstantsFactory factory = null;

            try
            {
                factory = new BoxVertexConstantsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICapsuleFragmentConstantsFactory CreateCapsuleFragmentConstantsFactory()
        {
            ICapsuleFragmentConstantsFactory factory = null;

            try
            {
                factory = new CapsuleFragmentConstantsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICapsuleVertexConstantsFactory CreateCapsuleVertexConstantsFactory()
        {
            ICapsuleVertexConstantsFactory factory = null;

            try
            {
                factory = new CapsuleVertexConstantsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICylinderFragmentConstantsFactory CreateCylinderFragmentConstantsFactory()
        {
            ICylinderFragmentConstantsFactory factory = null;

            try
            {
                factory = new CylinderFragmentConstantsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICylinderVertexConstantsFactory CreateCylinderVertexConstantsFactory()
        {
            ICylinderVertexConstantsFactory factory = null;

            try
            {
                factory = new CylinderVertexConstantsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IGlyphVertexConstantsFactory CreateGlyphVertexConstantsFactory()
        {
            IGlyphVertexConstantsFactory factory = null;

            try
            {
                factory = new GlyphVertexConstantsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IHTMLVertexConstantsFactory CreateHTMLVertexConstantsFactory()
        {
            IHTMLVertexConstantsFactory factory = null;

            try
            {
                factory = new HTMLVertexConstantsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IImageVertexConstantsFactory CreateImageVertexConstantsFactory()
        {
            IImageVertexConstantsFactory factory = null;

            try
            {
                factory = new ImageVertexConstantsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ILineVertexConstantsFactory CreateLineVertexConstantsFactory()
        {
            ILineVertexConstantsFactory factory = null;

            try
            {
                factory = new LineVertexConstantsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IMeshVertexConstantsFactory CreateMeshVertexConstantsFactory()
        {
            IMeshVertexConstantsFactory factory = null;

            try
            {
                factory = new MeshVertexConstantsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISphereFragmentConstantsFactory CreateSphereFragmentConstantsFactory()
        {
            ISphereFragmentConstantsFactory factory = null;

            try
            {
                factory = new SphereFragmentConstantsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISphereVertexConstantsFactory CreateSphereVertexConstantsFactory()
        {
            ISphereVertexConstantsFactory factory = null;

            try
            {
                factory = new SphereVertexConstantsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITriangleVertexConstantsFactory CreateTriangleVertexConstantsFactory()
        {
            ITriangleVertexConstantsFactory factory = null;

            try
            {
                factory = new TriangleVertexConstantsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IUILineVertexConstantsFactory CreateUILineVertexConstantsFactory()
        {
            IUILineVertexConstantsFactory factory = null;

            try
            {
                factory = new UILineVertexConstantsFactory();
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