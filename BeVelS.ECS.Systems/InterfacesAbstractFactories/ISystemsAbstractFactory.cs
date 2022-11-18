namespace BeVelS.ECS.Systems.InterfacesAbstractFactories
{
    using BeVelS.ECS.Systems.InterfacesFactories;

    public interface ISystemsAbstractFactory
    {
        ISequentialSystemFactory CreateSequentialSystemFactory();
    }
}