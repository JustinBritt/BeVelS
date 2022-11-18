namespace BeVelS.Graphics.Buffers.InterfacesFactories
{
    using Veldrid;

    using BeVelS.Graphics.Buffers.Interfaces;

    public interface IInstancesBufferFactory
    {
        IInstancesBuffer<T> Create<T>(
            DeviceBuffer deviceBuffer)
            where T : unmanaged;
    }
}