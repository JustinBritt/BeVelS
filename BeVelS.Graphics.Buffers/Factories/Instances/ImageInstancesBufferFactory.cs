namespace BeVelS.Graphics.Buffers.Factories.Instances
{
    using System;
    using System.Runtime.CompilerServices;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.Buffers.Classes;
    using BeVelS.Graphics.Buffers.Interfaces;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Instances;
    using BeVelS.Graphics.Images.Structs;

    internal sealed class ImageInstancesBufferFactory : IImageInstancesBufferFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ImageInstancesBufferFactory()
        {
        }

        public unsafe IInstancesBuffer<ImageInstance> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            int maximumPerDraw)
        {
            IInstancesBuffer<ImageInstance> instancesBuffer = null;

            try
            {
                instancesBuffer = new InstancesBuffer<ImageInstance>(
                    graphicsDevice.ResourceFactory.CreateBuffer(
                        bufferDescriptionFactory.Create(
                            (uint)(maximumPerDraw * Unsafe.SizeOf<ImageInstance>()),
                            BufferUsage.StructuredBufferReadOnly,
                            (uint)(Unsafe.SizeOf<ImageInstance>()))));
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instancesBuffer;
        }
    }
}