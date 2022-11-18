namespace BeVelS.ECS.Systems.TimeSteps.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Systems.TimeSteps.Factories;
    using BeVelS.ECS.Systems.TimeSteps.InterfacesAbstractFactories;
    using BeVelS.ECS.Systems.TimeSteps.InterfacesFactories;

    public sealed class TimeStepsAbstractFactory : ITimeStepsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TimeStepsAbstractFactory()
        {
        }

        public IFixedTimestepSystemFactory CreateFixedTimestepSystemFactory()
        {
            IFixedTimestepSystemFactory factory = null;

            try
            {
                factory = new FixedTimestepSystemFactory();
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