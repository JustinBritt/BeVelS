namespace BeVelS.Common.Parallelism.InterfacesFactories
{
    using BeVelS.Common.Parallelism.Interfaces;

    public interface IParallelLooperFactory
    {
        IParallelLooper Create();
    }
}