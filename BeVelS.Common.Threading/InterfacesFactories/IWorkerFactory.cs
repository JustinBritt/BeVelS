namespace BeVelS.Common.Threading.InterfacesFactories
{
    using BeVelS.Common.Threading.Structs;

    public interface IWorkerFactory
    {
        Worker Create();
    }
}