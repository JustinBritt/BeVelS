namespace BeVelS.Graphics.HTML.Factories.Batches
{
    using System;

    using log4net;

    using BeVelS.Graphics.HTML.Classes.Batches;
    using BeVelS.Graphics.HTML.Interfaces.Batches;
    using BeVelS.Graphics.HTML.InterfacesFactories.Batches;

    internal sealed class HTMLBatchFactory : IHTMLBatchFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HTMLBatchFactory()
        {
        }

        public IHTMLBatch Create()
        {
            IHTMLBatch HTMLBatch = null;

            try
            {
                HTMLBatch = new HTMLBatch();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return HTMLBatch;
        }
    }
}