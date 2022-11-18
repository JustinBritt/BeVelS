namespace BeVelS.Graphics.Fonts.Factories.Batches
{
    using System;

    using log4net;

    using BeVelS.Graphics.Fonts.Classes.Batches;
    using BeVelS.Graphics.Fonts.Interfaces.Batches;
    using BeVelS.Graphics.Fonts.InterfacesFactories.Batches;

    internal sealed class GlyphBatchFactory : IGlyphBatchFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public GlyphBatchFactory()
        {
        }

        public IGlyphBatch Create()
        {
            IGlyphBatch batch = null;

            try
            {
                batch = new GlyphBatch();
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