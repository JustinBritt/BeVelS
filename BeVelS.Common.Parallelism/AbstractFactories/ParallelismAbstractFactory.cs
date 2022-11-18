namespace BeVelS.Common.Parallelism.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Common.Parallelism.Factories;
    using BeVelS.Common.Parallelism.InterfacesAbstractFactories;
    using BeVelS.Common.Parallelism.InterfacesFactories;

    public sealed class ParallelismAbstractFactory : IParallelismAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ParallelismAbstractFactory()
        {
        }

        public IParallelLooperFactory CreateParallelLooperFactory()
        {
            IParallelLooperFactory factory = null;

            try
            {
                factory = new ParallelLooperFactory();
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