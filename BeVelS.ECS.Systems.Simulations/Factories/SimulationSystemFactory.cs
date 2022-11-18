namespace BeVelS.ECS.Systems.Simulations.Factories
{
    using System;

    using log4net;

    using BepuPhysics;

    using DefaultEcs;

    using BeVelS.ECS.Systems.Simulations.Classes;
    using BeVelS.ECS.Systems.Simulations.Interfaces;
    using BeVelS.ECS.Systems.Simulations.InterfacesFactories;

    internal sealed class SimulationSystemFactory : ISimulationSystemFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SimulationSystemFactory()
        {
        }

        public ISimulationSystem Create(
            Simulation simulation,
            World world)
        {
            ISimulationSystem system = null;

            try
            {
                system = new SimulationSystem(
                    simulation,
                    world);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return system;
        }
    }
}