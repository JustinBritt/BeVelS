namespace BeVelS.ECS.Systems.TimeSteps.Classes
{
    using BepuPhysics;

    using BepuUtilities;

    using DefaultEcs;

    using BeVelS.Common.Threading.InterfacesFactories;

    using BeVelS.ECS.Systems.TimeSteps.Interfaces;

    using BeVelS.Physics.TimeSteps.Interfaces;
    using BeVelS.Physics.TimeSteps.InterfacesFactories;

    internal sealed class FixedTimestepSystem : IFixedTimestepSystem
    {
        public FixedTimestepSystem(
            ISimpleTargetThreadCountHeuristicFactory simpleTargetThreadCountHeuristicFactory,
            IThreadCountFactory threadCountFactory,
            IThreadDispatcherFactory threadDispatcherFactory,
            IFixedTimestepFactory fixedTimestepFactory,
            Simulation simulation,
            World world)
        {
            this.Simulation = simulation;

            this.World = world;

            this.World.Subscribe(
                this);

            this.ThreadDispatcher = threadDispatcherFactory.Create(
                simpleTargetThreadCountHeuristicFactory.Create().Estimate(
                    threadCountFactory));

            this.FixedTimestep = fixedTimestepFactory.Create();
        }

        public IFixedTimestep FixedTimestep { get; }

        public bool IsEnabled { get; set; }

        private Simulation Simulation { get; }

        public IThreadDispatcher ThreadDispatcher { get; private set; }

        private World World { get; }

        public void Update(
            float state)
        {
            this.FixedTimestep.Timestep(
                this.Simulation,
                this.ThreadDispatcher,
                timestepsPerUpdate: 2,
                timeToSimulate: 1f / 60f);
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;
            }
        }
    }
}