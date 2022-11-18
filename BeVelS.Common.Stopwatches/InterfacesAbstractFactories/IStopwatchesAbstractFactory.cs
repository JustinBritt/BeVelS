namespace BeVelS.Common.Stopwatches.InterfacesAbstractFactories
{
    using BeVelS.Common.Stopwatches.InterfacesFactories;

    public interface IStopwatchesAbstractFactory
    {
        IStopwatchStateFactory CreateStopwatchStateFactory();
    }
}