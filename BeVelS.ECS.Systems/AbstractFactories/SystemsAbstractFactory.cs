namespace BeVelS.ECS.Systems.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Systems.Factories;
    using BeVelS.ECS.Systems.InterfacesAbstractFactories;
    using BeVelS.ECS.Systems.InterfacesFactories;

    public sealed class SystemsAbstractFactory : ISystemsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SystemsAbstractFactory()
        {
        }

        public ISequentialSystemFactory CreateSequentialSystemFactory()
        {
            ISequentialSystemFactory factory = null;

            try
            {
                factory = new SequentialSystemFactory();
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