namespace BeVelS.Graphics.Buffers.InterfacesFactories
{
    using System;

    using Veldrid;

    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;

    public interface IDeviceBufferFactory
    {
        DeviceBuffer CreateBuffer(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            uint sizeInBytes,
            BufferUsage usage);

        DeviceBuffer CreateIndexBuffer(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            ReadOnlySpan<uint> indices);

        DeviceBuffer CreateMatrix4x4DynamicUniformBuffer(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice);
    }
}