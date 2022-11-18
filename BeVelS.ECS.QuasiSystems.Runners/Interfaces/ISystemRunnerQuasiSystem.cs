namespace BeVelS.ECS.QuasiSystems.Runners.Interfaces
{
    using BeVelS.Common.Threading.Interfaces.Tasks;

    public interface ISystemRunnerQuasiSystem
    {
        ICancellableTask CancellableTask { get; }
    }
}