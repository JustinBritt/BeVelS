namespace BeVelS.Graphics.Images.Factories.Batches
{
    using System;

    using log4net;

    using BeVelS.Graphics.Images.Classes.Batches;
    using BeVelS.Graphics.Images.Interfaces.Batches;
    using BeVelS.Graphics.Images.InterfacesFactories.Batches;
    
    internal sealed class ImageBatchFactory : IImageBatchFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ImageBatchFactory()
        {
        }

        public IImageBatch Create()
        {
            IImageBatch batch = null;

            try
            {
                batch = new ImageBatch();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return batch;
        }
    }
}