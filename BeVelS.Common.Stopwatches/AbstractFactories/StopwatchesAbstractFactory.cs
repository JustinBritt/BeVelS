namespace BeVelS.Common.Stopwatches.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Common.Stopwatches.Factories;
    using BeVelS.Common.Stopwatches.InterfacesAbstractFactories;
    using BeVelS.Common.Stopwatches.InterfacesFactories;

    public sealed class StopwatchesAbstractFactory : IStopwatchesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public StopwatchesAbstractFactory()
        {
        }

        public IStopwatchStateFactory CreateStopwatchStateFactory()
        {
            IStopwatchStateFactory factory = null;

            try
            {
                factory = new StopwatchStateFactory();
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