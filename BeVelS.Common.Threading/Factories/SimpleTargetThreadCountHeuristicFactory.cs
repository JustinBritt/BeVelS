namespace BeVelS.Common.Threading.Factories
{
    using System;

    using log4net;

    using BeVelS.Common.Threading.Classes;
    using BeVelS.Common.Threading.Interfaces;
    using BeVelS.Common.Threading.InterfacesFactories;

    internal sealed class SimpleTargetThreadCountHeuristicFactory : ISimpleTargetThreadCountHeuristicFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SimpleTargetThreadCountHeuristicFactory()
        {
        }

        public ISimpleTargetThreadCountHeuristic Create()
        {
            ISimpleTargetThreadCountHeuristic simpleTargetThreadCountHeuristic = null;

            try
            {
                simpleTargetThreadCountHeuristic = new SimpleTargetThreadCountHeuristic();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return simpleTargetThreadCountHeuristic;
        }
    }
}