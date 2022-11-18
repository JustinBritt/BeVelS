namespace BeVelS.Graphics.Buffers.Interfaces
{
    using System;

    using Veldrid;

    public interface IConstantsBuffer<T> : IDisposable
        where T : unmanaged
    {
        DeviceBuffer DeviceBuffer { get; }

        void Update(
            GraphicsDevice graphicsDevice,
            T source);
    }
}