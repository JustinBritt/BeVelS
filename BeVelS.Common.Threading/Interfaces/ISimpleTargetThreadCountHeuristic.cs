namespace BeVelS.Common.Threading.Interfaces
{
    using BeVelS.Common.Threading.InterfacesFactories;

    public interface ISimpleTargetThreadCountHeuristic
    {
        IThreadCount Estimate(
            IThreadCountFactory threadCountFactory);
    }
}