namespace BeVelS.Graphics.Buffers.Interfaces
{
    using System;

    using Veldrid;

    public interface IIndexBuffer<T> : IDisposable
        where T : unmanaged
    {
        DeviceBuffer DeviceBuffer { get; }

        IndexFormat IndexFormat { get; }

        T[] Indices { get; }

        void Update(
            GraphicsDevice graphicsDevice);
    }
}