namespace BeVelS.Common.Threading.InterfacesFactories
{
    using BepuUtilities;

    using BeVelS.Common.Threading.Interfaces;

    public interface IThreadDispatcherFactory
    {
        IThreadDispatcher Create(
            IThreadCount threadCount);
    }
}