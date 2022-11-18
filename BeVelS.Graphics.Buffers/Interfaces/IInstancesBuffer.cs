namespace BeVelS.Graphics.Buffers.Interfaces
{
    using System;

    using Veldrid;

    public interface IInstancesBuffer<T> : IDisposable
        where T : unmanaged
    {
        DeviceBuffer DeviceBuffer { get; }

        void Update(
            GraphicsDevice graphicsDevice,
            ReadOnlySpan<T> instances);
    }
}