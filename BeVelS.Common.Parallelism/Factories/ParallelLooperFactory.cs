namespace BeVelS.Common.Parallelism.Factories
{
    using System;

    using log4net;

    using BeVelS.Common.Parallelism.Classes;
    using BeVelS.Common.Parallelism.Interfaces;

    using BeVelS.Common.Parallelism.InterfacesFactories;

    internal sealed class ParallelLooperFactory : IParallelLooperFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ParallelLooperFactory()
        {
        }

        public IParallelLooper Create()
        {
            IParallelLooper parallelLooper = null;

            try
            {
                parallelLooper = new ParallelLooper();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parallelLooper;
        }
    }
}