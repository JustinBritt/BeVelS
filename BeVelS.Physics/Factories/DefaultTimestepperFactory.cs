namespace BeVelS.Physics.Factories
{
    using System;

    using log4net;

    using BepuPhysics;

    using BeVelS.Physics.InterfacesFactories;

    internal sealed class DefaultTimestepperFactory : IDefaultTimestepperFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DefaultTimestepperFactory()
        {
        }

        public ITimestepper Create()
        {
            ITimestepper timestepper = null;

            try
            {
                timestepper = new DefaultTimestepper();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return timestepper;
        }
    }
}