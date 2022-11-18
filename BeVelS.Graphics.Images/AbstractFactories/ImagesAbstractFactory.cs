namespace BeVelS.Graphics.Images.AbstractFactories
{
    using System;
    
    using log4net;

    using BeVelS.Graphics.Images.Factories;
    using BeVelS.Graphics.Images.Factories.Batches;
    using BeVelS.Graphics.Images.InterfacesAbstractFactories;
    using BeVelS.Graphics.Images.InterfacesFactories;
    using BeVelS.Graphics.Images.InterfacesFactories.Batches;

    public sealed class ImagesAbstractFactory : IImagesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ImagesAbstractFactory()
        {
        }

        public IImageBatchFactory CreateImageBatchFactory()
        {
            IImageBatchFactory factory = null;

            try
            {
                factory = new ImageBatchFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IImageFactory CreateImageFactory()
        {
            IImageFactory factory = null;

            try
            {
                factory = new ImageFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IImageInstanceFactory CreateImageInstanceFactory()
        {
            IImageInstanceFactory factory = null;

            try
            {
                factory = new ImageInstanceFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IRenderableImageFactory CreateRenderableImageFactory()
        {
            IRenderableImageFactory factory = null;

            try
            {
                factory = new RenderableImageFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IRenderableImagesFactory CreateRenderableImagesFactory()
        {
            IRenderableImagesFactory factory = null;

            try
            {
                factory = new RenderableImagesFactory();
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