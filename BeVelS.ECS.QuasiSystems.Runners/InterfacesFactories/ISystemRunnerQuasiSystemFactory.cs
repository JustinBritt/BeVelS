namespace BeVelS.ECS.QuasiSystems.Runners.InterfacesFactories
{
    using DefaultEcs;
    using DefaultEcs.System;

    using BeVelS.Common.Stopwatches.InterfacesFactories;
    using BeVelS.Common.Threading.InterfacesFactories.Tasks;

    using BeVelS.ECS.QuasiSystems.Runners.Interfaces;

    public interface ISystemRunnerQuasiSystemFactory
    {
        ISystemRunnerQuasiSystem Create<T>(
            IStopwatchStateFactory stopwatchStateFactory,
            ICancellableTaskFactory cancellableTaskFactory,
            ISystem<T> system,
            World world);
    }
}