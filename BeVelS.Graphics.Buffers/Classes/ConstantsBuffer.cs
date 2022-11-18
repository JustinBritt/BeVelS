namespace BeVelS.Graphics.Buffers.Classes
{
    using Veldrid;

    using BeVelS.Graphics.Buffers.Interfaces;

    internal sealed class ConstantsBuffer<T> : IConstantsBuffer<T>
        where T : unmanaged
    {
        public ConstantsBuffer(
            DeviceBuffer deviceBuffer)
        {
            this.DeviceBuffer = deviceBuffer;
        }

        public DeviceBuffer DeviceBuffer { get; }

        public void Update(
            GraphicsDevice graphicsDevice,
            T source)
        {
            this.Update(
                0,
                this.DeviceBuffer,
                graphicsDevice,
                source);
        }

        private void Update(
            uint bufferOffsetInBytes,
            DeviceBuffer deviceBuffer,
            GraphicsDevice graphicsDevice,
            T source)
        {
            graphicsDevice.UpdateBuffer(
                deviceBuffer,
                bufferOffsetInBytes,
                source);
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