namespace BeVelS.Graphics.Images.Factories
{
    using System;

    using log4net;

    using BeVelS.Graphics.Images.Classes;
    using BeVelS.Graphics.Images.Interfaces;
    using BeVelS.Graphics.Images.InterfacesFactories;

    internal sealed class RenderableImagesFactory : IRenderableImagesFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RenderableImagesFactory()
        {
        }

        public IRenderableImages Create()
        {
            IRenderableImages renderableImages = null;

            try
            {
                renderableImages = new RenderableImages();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return renderableImages;
        }
    }
}