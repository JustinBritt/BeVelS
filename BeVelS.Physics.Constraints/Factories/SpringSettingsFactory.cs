namespace BeVelS.Physics.Constraints.Factories
{
    using System;

    using log4net;

    using BepuPhysics.Constraints;

    using BeVelS.Physics.Constraints.InterfacesFactories;

    internal sealed class SpringSettingsFactory : ISpringSettingsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SpringSettingsFactory()
        {
        }

        public SpringSettings Create(
            float frequency,
            float dampingRatio)
        {
            SpringSettings springSettings = default;

            try
            {
                springSettings = new SpringSettings(
                    frequency: frequency,
                    dampingRatio: dampingRatio);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return springSettings;
        }
    }
}