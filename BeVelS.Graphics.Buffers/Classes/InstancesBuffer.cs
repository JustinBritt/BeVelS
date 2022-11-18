namespace BeVelS.Graphics.Buffers.Classes
{
    using System;

    using Veldrid;

    using BeVelS.Graphics.Buffers.Interfaces;

    internal sealed class InstancesBuffer<T> : IInstancesBuffer<T>
        where T : unmanaged
    {
        public InstancesBuffer(
            DeviceBuffer deviceBuffer)
        {
            this.DeviceBuffer = deviceBuffer;
        }

        public DeviceBuffer DeviceBuffer { get; }

        public void Update(
            GraphicsDevice graphicsDevice,
            ReadOnlySpan<T> instances)
        {
            this.Update(
                0,
                this.DeviceBuffer,
                graphicsDevice,
                instances);
        }

        private void Update(
            uint bufferOffsetInBytes,
            DeviceBuffer deviceBuffer,
            GraphicsDevice graphicsDevice,
            ReadOnlySpan<T> instances)
        {
            graphicsDevice.UpdateBuffer(
                deviceBuffer,
                bufferOffsetInBytes,
                instances);
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