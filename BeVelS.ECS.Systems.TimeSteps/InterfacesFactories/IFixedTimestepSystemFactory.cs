namespace BeVelS.ECS.Systems.TimeSteps.InterfacesFactories
{
    using BepuPhysics;

    using DefaultEcs;

    using BeVelS.Common.Threading.InterfacesFactories;

    using BeVelS.ECS.Systems.TimeSteps.Interfaces;

    using BeVelS.Physics.TimeSteps.InterfacesFactories;

    public interface IFixedTimestepSystemFactory
    {
        IFixedTimestepSystem Create(
            ISimpleTargetThreadCountHeuristicFactory simpleTargetThreadCountHeuristicFactory,
            IThreadCountFactory threadCountFactory,
            IThreadDispatcherFactory threadDispatcherFactory,
            IFixedTimestepFactory fixedTimestepFactory,
            Simulation simulation,
            World world);
    }
}