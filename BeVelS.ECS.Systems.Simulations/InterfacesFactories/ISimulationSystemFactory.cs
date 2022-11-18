namespace BeVelS.ECS.Systems.Simulations.InterfacesFactories
{
    using BepuPhysics;

    using DefaultEcs;

    using BeVelS.ECS.Systems.Simulations.Interfaces;

    public interface ISimulationSystemFactory
    {
        ISimulationSystem Create(
            Simulation simulation,
            World world);
    }
}