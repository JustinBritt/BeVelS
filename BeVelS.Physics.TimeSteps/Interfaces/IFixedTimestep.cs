namespace BeVelS.Physics.TimeSteps.Interfaces
{
    using BepuPhysics;

    using BepuUtilities;

    public interface IFixedTimestep
    {
        void Timestep(
            Simulation simulation,
            IThreadDispatcher threadDispatcher,
            int timestepsPerUpdate,
            float timeToSimulate);
    }
}