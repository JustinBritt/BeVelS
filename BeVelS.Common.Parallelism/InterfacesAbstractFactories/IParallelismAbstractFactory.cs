namespace BeVelS.Common.Parallelism.InterfacesAbstractFactories
{
    using BeVelS.Common.Parallelism.InterfacesFactories;

    public interface IParallelismAbstractFactory
    {
        IParallelLooperFactory CreateParallelLooperFactory();
    }
}