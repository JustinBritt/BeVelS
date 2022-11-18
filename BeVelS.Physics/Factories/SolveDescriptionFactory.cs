namespace BeVelS.Physics.Factories
{
    using System;

    using log4net;

    using BepuPhysics;

    using BeVelS.Physics.InterfacesFactories;

    internal sealed class SolveDescriptionFactory : ISolveDescriptionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SolveDescriptionFactory()
        {
        }

        public SolveDescription Create(
            int velocityIterationCount, 
            int substepCount,
            int fallbackBatchThreshold = 64)
        {
            SolveDescription solveDescription = default;

            try
            {
                solveDescription = new SolveDescription(
                    velocityIterationCount: velocityIterationCount,
                    substepCount: substepCount,
                    fallbackBatchThreshold: fallbackBatchThreshold);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return solveDescription;
        }
    }
}