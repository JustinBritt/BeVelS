namespace BeVelS.Graphics.Buffers.Classes
{
    using System;

    using Veldrid;

    using BeVelS.Graphics.Buffers.Interfaces;

    internal sealed class IndexBuffer<T> : IIndexBuffer<T>
        where T : unmanaged
    {
        public IndexBuffer(
            DeviceBuffer deviceBuffer,
            IndexFormat indexFormat,
            T[] indices)
        {
            this.DeviceBuffer = deviceBuffer;

            this.IndexFormat = indexFormat;

            this.Indices = indices;
        }

        public DeviceBuffer DeviceBuffer { get; }

        public IndexFormat IndexFormat { get; }

        public T[] Indices { get; }

        public void Update(
            GraphicsDevice graphicsDevice)
        {
            this.Update(
                0,
                this.DeviceBuffer,
                graphicsDevice,
                this.Indices);
        }

        private void Update(
            uint bufferOffsetInBytes,
            DeviceBuffer deviceBuffer,
            GraphicsDevice graphicsDevice,
            ReadOnlySpan<T> indices)
        {
            graphicsDevice.UpdateBuffer(
                deviceBuffer,
                bufferOffsetInBytes,
                indices);
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                this.DeviceBuffer.Dispose();
            }
        }
    }
}