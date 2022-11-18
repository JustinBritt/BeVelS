namespace BeVelS.Physics.Constraints.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Physics.Constraints.Factories;
    using BeVelS.Physics.Constraints.InterfacesAbstractFactories;
    using BeVelS.Physics.Constraints.InterfacesFactories;

    public sealed class ConstraintsAbstractFactory : IConstraintsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConstraintsAbstractFactory()
        {
        }

        public IBallSocketFactory CreateBallSocketFactory()
        {
            IBallSocketFactory factory = null;

            try
            {
                factory = new BallSocketFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ILineExtractorFactory CreateLineExtractorFactory()
        {
            ILineExtractorFactory factory = null;

            try
            {
                factory = new LineExtractorFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IPointOnLineServoFactory CreatePointOnLineServoFactory()
        {
            IPointOnLineServoFactory factory = null;

            try
            {
                factory = new PointOnLineServoFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISpringSettingsFactory CreateSpringSettingsFactory()
        {
            ISpringSettingsFactory factory = null;

            try
            {
                factory = new SpringSettingsFactory();
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