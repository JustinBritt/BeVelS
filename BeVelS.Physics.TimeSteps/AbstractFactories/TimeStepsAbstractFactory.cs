namespace BeVelS.Physics.TimeSteps.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Physics.TimeSteps.Factories;
    using BeVelS.Physics.TimeSteps.InterfacesAbstractFactories;
    using BeVelS.Physics.TimeSteps.InterfacesFactories;

    public sealed class TimeStepsAbstractFactory : ITimeStepsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TimeStepsAbstractFactory()
        {
        }

        public IFixedTimestepFactory CreateFixedTimestepFactory()
        {
            IFixedTimestepFactory factory = null;

            try
            {
                factory = new FixedTimestepFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IVariableTimestepFactory CreateVariableTimestepFactory()
        {
            IVariableTimestepFactory factory = null;

            try
            {
                factory = new VariableTimestepFactory();
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