namespace BeVelS.ECS.QuasiSystems.Runners.InterfacesAbstractFactories
{
    using BeVelS.ECS.QuasiSystems.Runners.InterfacesFactories;

    public interface IRunnersAbstractFactory
    {
        ISystemRunnerQuasiSystemFactory CreateSystemRunnerQuasiSystemFactory();
    }
}