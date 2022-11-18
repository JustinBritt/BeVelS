namespace BeVelS.Physics.TimeSteps.Interfaces
{
    using BepuPhysics;

    using BepuUtilities;

    public interface IVariableTimestep
    {
        void Timestep(
            float dt,
            Simulation simulation,
            float targetTimestepDuration,
            IThreadDispatcher threadDispatcher);
    }
}