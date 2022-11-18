namespace BeVelS.ECS.Systems.Simulations.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Systems.Simulations.Factories;
    using BeVelS.ECS.Systems.Simulations.InterfacesAbstractFactories;
    using BeVelS.ECS.Systems.Simulations.InterfacesFactories;

    public sealed class SimulationsAbstractFactory : ISimulationsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SimulationsAbstractFactory()
        {
        }

        public ISimulationSystemFactory CreateSimulationSystemFactory()
        {
            ISimulationSystemFactory factory = null;

            try
            {
                factory = new SimulationSystemFactory();
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