namespace BeVelS.ECS.Systems.Simulations.Classes
{
    using BepuPhysics;
    using BepuPhysics.ECS.Components.Extensions;
    using BepuPhysics.ECS.Components.Structs;

    using DefaultEcs;

    using BeVelS.ECS.Systems.Simulations.Interfaces;

    internal sealed class SimulationSystem : ISimulationSystem
    {
        public SimulationSystem(
            Simulation simulation,
            World world)
        {
            this.Simulation = simulation;

            this.World = world;

            this.World.Subscribe(
                this);

            Entity simulationEntity = this.World.CreateEntity();

            SimulationComponent simulationComponent = default;

            simulationComponent.Value = this.Simulation;

            simulationEntity.Set<SimulationComponent>(
                simulationComponent);
        }

        public bool IsEnabled { get; set; }

        public Simulation Simulation { get; private set; }

        private World World { get; }

        public void Update(
            float state)
        {
            if (this.IsEnabled)
            {
                ref SimulationComponent simulationComponent = ref this.World.GetSimulationComponentLastRef();

                simulationComponent.Value = this.Simulation;
            }
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                this.Simulation.Dispose();
            }
        }
    }
}