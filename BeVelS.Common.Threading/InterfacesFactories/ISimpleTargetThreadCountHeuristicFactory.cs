namespace BeVelS.Common.Threading.InterfacesFactories
{
    using BeVelS.Common.Threading.Interfaces;

    public interface ISimpleTargetThreadCountHeuristicFactory
    {
        ISimpleTargetThreadCountHeuristic Create();
    }
}