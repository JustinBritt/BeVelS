namespace BeVelS.ECS.Systems.BufferPools.InterfacesAbstractFactories
{
    using BeVelS.ECS.Systems.BufferPools.InterfacesFactories;

    public interface IBufferPoolsAbstractFactory
    {
        IBufferPoolSystemFactory CreateBufferPoolSystemFactory();
    }
}