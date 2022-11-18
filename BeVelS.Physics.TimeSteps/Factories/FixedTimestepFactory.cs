namespace BeVelS.Physics.TimeSteps.Factories
{
    using System;

    using log4net;

    using BeVelS.Physics.TimeSteps.Classes;
    using BeVelS.Physics.TimeSteps.Interfaces;
    using BeVelS.Physics.TimeSteps.InterfacesFactories;

    internal sealed class FixedTimestepFactory : IFixedTimestepFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FixedTimestepFactory()
        {
        }

        public IFixedTimestep Create()
        {
            IFixedTimestep fixedTimestep = null;

            try
            {
                fixedTimestep = new FixedTimestep();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return fixedTimestep;
        }
    }
}