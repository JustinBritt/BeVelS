namespace BeVelS.ECS.Systems.TimeSteps.Factories
{
    using System;

    using log4net;

    using BepuPhysics;

    using DefaultEcs;

    using BeVelS.Common.Threading.InterfacesFactories;

    using BeVelS.ECS.Systems.TimeSteps.Classes;
    using BeVelS.ECS.Systems.TimeSteps.Interfaces;
    using BeVelS.ECS.Systems.TimeSteps.InterfacesFactories;
    
    using BeVelS.Physics.TimeSteps.InterfacesFactories;

    internal sealed class FixedTimestepSystemFactory : IFixedTimestepSystemFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FixedTimestepSystemFactory()
        {
        }

        public IFixedTimestepSystem Create(
            ISimpleTargetThreadCountHeuristicFactory simpleTargetThreadCountHeuristicFactory,
            IThreadCountFactory threadCountFactory,
            IThreadDispatcherFactory threadDispatcherFactory,
            IFixedTimestepFactory fixedTimestepFactory,
            Simulation simulation,
            World world)
        {
            IFixedTimestepSystem system = null;

            try
            {
                system = new FixedTimestepSystem(
                    simpleTargetThreadCountHeuristicFactory,
                    threadCountFactory,
                    threadDispatcherFactory,
                    fixedTimestepFactory,
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