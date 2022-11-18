namespace BeVelS.Physics.Constraints.Factories
{
    using System;

    using log4net;

    using BepuUtilities.Memory;

    using BeVelS.Common.Parallelism.Interfaces;
    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Physics.Constraints.Classes;
    using BeVelS.Physics.Constraints.Interfaces;
    using BeVelS.Physics.Constraints.InterfacesFactories;

    internal sealed class LineExtractorFactory : ILineExtractorFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LineExtractorFactory()
        {
        }

        public ILineExtractor Create(
            IVector3Factory vector3Factory,
            BufferPool bufferPool,
            IParallelLooper parallelLooper,
            int initialLineCapacity = 8192)
        {
            ILineExtractor lineExtractor = null;

            try
            {
                lineExtractor = new LineExtractor(
                    pool: bufferPool,
                    looper: parallelLooper,
                    initialLineCapacity: initialLineCapacity);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return lineExtractor;
        }
    }
}