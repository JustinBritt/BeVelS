namespace BeVelS.Common.Threading.InterfacesAbstractFactories
{
    using BeVelS.Common.Threading.InterfacesFactories;
    using BeVelS.Common.Threading.InterfacesFactories.Tasks;

    public interface IThreadingAbstractFactory
    {
        ICancellableTaskFactory CreateCancellableTaskFactory();

        ICancellationTokenSourceFactory CreateCancellationTokenSourceFactory();

        ISimpleTargetThreadCountHeuristicFactory CreateSimpleTargetThreadCountHeuristicFactory();

        IThreadCountFactory CreateThreadCountFactory();

        IThreadDispatcherFactory CreateThreadDispatcherFactory();

        IWorkerFactory CreateWorkerFactory();
    }
}