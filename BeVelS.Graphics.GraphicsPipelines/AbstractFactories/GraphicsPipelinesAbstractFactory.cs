namespace BeVelS.Graphics.GraphicsPipelines.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.GraphicsPipelines.Factories;
    using BeVelS.Graphics.GraphicsPipelines.Factories.Descriptions;
    using BeVelS.Graphics.GraphicsPipelines.InterfacesAbstractFactories;
    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories;
    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories.Descriptions;

    public sealed class GraphicsPipelinesAbstractFactory : IGraphicsPipelinesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public GraphicsPipelinesAbstractFactory()
        {
        }

        public IBackgroundGraphicsPipelineFactory CreateBackgroundGraphicsPipelineFactory()
        {
            IBackgroundGraphicsPipelineFactory factory = null;

            try
            {
                factory = new BackgroundGraphicsPipelineFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IBoxGraphicsPipelineFactory CreateBoxGraphicsPipelineFactory()
        {
            IBoxGraphicsPipelineFactory factory = null;

            try
            {
                factory = new BoxGraphicsPipelineFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICapsuleGraphicsPipelineFactory CreateCapsuleGraphicsPipelineFactory()
        {
            ICapsuleGraphicsPipelineFactory factory = null;

            try
            {
                factory = new CapsuleGraphicsPipelineFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICylinderGraphicsPipelineFactory CreateCylinderGraphicsPipelineFactory()
        {
            ICylinderGraphicsPipelineFactory factory = null;

            try
            {
                factory = new CylinderGraphicsPipelineFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IGlyphGraphicsPipelineFactory CreateGlyphGraphicsPipelineFactory()
        {
            IGlyphGraphicsPipelineFactory factory = null;

            try
            {
                factory = new GlyphGraphicsPipelineFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IGraphicsPipelineDescriptionFactory CreateGraphicsPipelineDescriptionFactory()
        {
            IGraphicsPipelineDescriptionFactory factory = null;

            try
            {
                factory = new GraphicsPipelineDescriptionFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IHTMLGraphicsPipelineFactory CreateHTMLGraphicsPipelineFactory()
        {
            IHTMLGraphicsPipelineFactory factory = null;

            try
            {
                factory = new HTMLGraphicsPipelineFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IImageGraphicsPipelineFactory CreateImageGraphicsPipelineFactory()
        {
            IImageGraphicsPipelineFactory factory = null;

            try
            {
                factory = new ImageGraphicsPipelineFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ILineGraphicsPipelineFactory CreateLineGraphicsPipelineFactory()
        {
            ILineGraphicsPipelineFactory factory = null;

            try
            {
                factory = new LineGraphicsPipelineFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IMeshGraphicsPipelineFactory CreateMeshGraphicsPipelineFactory()
        {
            IMeshGraphicsPipelineFactory factory = null;

            try
            {
                factory = new MeshGraphicsPipelineFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISphereGraphicsPipelineFactory CreateSphereGraphicsPipelineFactory()
        {
            ISphereGraphicsPipelineFactory factory = null;

            try
            {
                factory = new SphereGraphicsPipelineFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITriangleGraphicsPipelineFactory CreateTriangleGraphicsPipelineFactory()
        {
            ITriangleGraphicsPipelineFactory factory = null;

            try
            {
                factory = new TriangleGraphicsPipelineFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IUILineGraphicsPipelineFactory CreateUILineGraphicsPipelineFactory()
        {
            IUILineGraphicsPipelineFactory factory = null;

            try
            {
                factory = new UILineGraphicsPipelineFactory();
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