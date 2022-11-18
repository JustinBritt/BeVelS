namespace BeVelS.ECS.Systems.Simulations.InterfacesAbstractFactories
{
    using BeVelS.ECS.Systems.Simulations.InterfacesFactories;

    public interface ISimulationsAbstractFactory
    {
        ISimulationSystemFactory CreateSimulationSystemFactory();
    }
}