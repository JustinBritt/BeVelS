namespace BeVelS.Graphics.Buffers.InterfacesFactories
{
    using Veldrid;

    using BeVelS.Graphics.Buffers.Interfaces;

    public interface IConstantsBufferFactory
    {
        IConstantsBuffer<T> Create<T>(
            DeviceBuffer deviceBuffer)
            where T : unmanaged;
    }
}