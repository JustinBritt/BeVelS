namespace BeVelS.ECS.Systems.Simulations.Interfaces
{
    using BepuPhysics;

    using DefaultEcs.System;

    public interface ISimulationSystem : ISystem<float>
    {
        Simulation Simulation { get; }
    }
}