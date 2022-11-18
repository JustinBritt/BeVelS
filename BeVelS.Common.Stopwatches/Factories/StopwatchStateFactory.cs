namespace BeVelS.Common.Stopwatches.Factories
{
    using System;

    using log4net;

    using BeVelS.Common.Stopwatches.Classes;
    using BeVelS.Common.Stopwatches.Interfaces;
    using BeVelS.Common.Stopwatches.InterfacesFactories;

    internal sealed class StopwatchStateFactory : IStopwatchStateFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public StopwatchStateFactory()
        {
        }

        public IStopwatchState Create()
        {
            IStopwatchState stopwatchState = null;

            try
            {
                stopwatchState = new StopwatchState();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return stopwatchState;
        }
    }
}