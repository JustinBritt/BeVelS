namespace BeVelS.Common.Utilities.InterfacesFactories.Memory
{
    using BepuUtilities.Memory;

    public interface IBufferPoolFactory
    {
        IUnmanagedMemoryPool Create();
    }
}