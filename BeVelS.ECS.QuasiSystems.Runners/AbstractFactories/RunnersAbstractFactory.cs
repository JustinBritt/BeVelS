namespace BeVelS.ECS.QuasiSystems.Runners.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.QuasiSystems.Runners.Factories;
    using BeVelS.ECS.QuasiSystems.Runners.InterfacesAbstractFactories;
    using BeVelS.ECS.QuasiSystems.Runners.InterfacesFactories;
    
    public sealed class RunnersAbstractFactory : IRunnersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RunnersAbstractFactory()
        {
        }

        public ISystemRunnerQuasiSystemFactory CreateSystemRunnerQuasiSystemFactory()
        {
            ISystemRunnerQuasiSystemFactory factory = null;

            try
            {
                factory = new SystemRunnerQuasiSystemFactory();
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