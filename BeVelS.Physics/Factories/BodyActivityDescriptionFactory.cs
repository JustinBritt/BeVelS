namespace BeVelS.Physics.Factories
{
    using System;

    using log4net;

    using BepuPhysics;

    using BeVelS.Physics.InterfacesFactories;

    internal sealed class BodyActivityDescriptionFactory : IBodyActivityDescriptionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BodyActivityDescriptionFactory()
        {
        }

        public BodyActivityDescription Create(
            float sleepThreshold)
        {
            BodyActivityDescription bodyActivityDescription = default;

            try
            {
                bodyActivityDescription = new BodyActivityDescription();

                bodyActivityDescription.SleepThreshold = sleepThreshold;
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return bodyActivityDescription;
        }
    }
}