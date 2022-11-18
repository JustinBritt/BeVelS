namespace BeVelS.Physics.InterfacesFactories
{
    using BepuPhysics;

    public interface ISolveDescriptionFactory
    {
        SolveDescription Create(
            int velocityIterationCount,
            int substepCount,
            int fallbackBatchThreshold = 64);
    }
}