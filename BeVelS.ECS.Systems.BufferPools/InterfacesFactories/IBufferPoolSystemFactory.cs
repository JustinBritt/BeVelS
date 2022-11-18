namespace BeVelS.ECS.Systems.BufferPools.InterfacesFactories
{
    using DefaultEcs;

    using BeVelS.Common.Utilities.InterfacesFactories.Memory;

    using BeVelS.ECS.Systems.BufferPools.Interfaces;

    public interface IBufferPoolSystemFactory
    {
        IBufferPoolSystem Create(
            IBufferPoolFactory bufferPoolFactory,
            World world);
    }
}