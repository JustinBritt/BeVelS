namespace BeVelS.Graphics.Buffers.Factories
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.Buffers.InterfacesFactories;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;

    internal sealed class DeviceBufferFactory : IDeviceBufferFactory
    {
        private const uint Matrix4x4SizeInBytes = 4 * 4 * sizeof(float);

        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DeviceBufferFactory()
        {
        }

        public DeviceBuffer CreateIndexBuffer(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            ReadOnlySpan<uint> indices)
        {
            DeviceBuffer deviceBuffer = null;

            try
            {
                deviceBuffer = graphicsDevice.ResourceFactory.CreateBuffer(
                    bufferDescriptionFactory.Create(
                        (uint)indices.Length * sizeof(uint),
                        BufferUsage.IndexBuffer));
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return deviceBuffer;
                
        }

        public DeviceBuffer CreateMatrix4x4DynamicUniformBuffer(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice)
        {
            DeviceBuffer deviceBuffer = null;

            try
            {
                deviceBuffer = graphicsDevice.ResourceFactory.CreateBuffer(
                    bufferDescriptionFactory.Create(
                        Matrix4x4SizeInBytes,
                        BufferUsage.UniformBuffer
                        |
                        BufferUsage.Dynamic));
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return deviceBuffer;
        }

        public DeviceBuffer CreateBuffer(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            uint sizeInBytes,
            BufferUsage usage)
        {
            DeviceBuffer deviceBuffer = null;

            try
            {
                deviceBuffer = graphicsDevice.ResourceFactory.CreateBuffer(
                    bufferDescriptionFactory.Create(
                        sizeInBytes,
                        usage));
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return deviceBuffer;
        }
    }
}