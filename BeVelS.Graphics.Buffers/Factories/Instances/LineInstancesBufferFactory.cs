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
    using BeVelS.Physics.Constraints.Structs.Lines;

    internal sealed class LineInstancesBufferFactory : ILineInstancesBufferFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LineInstancesBufferFactory()
        {
        }

        public unsafe IInstancesBuffer<LineInstance> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            int maximumInstancesPerDraw)
        {
            IInstancesBuffer<LineInstance> instancesBuffer = null;

            try
            {
                instancesBuffer = new InstancesBuffer<LineInstance>(
                    graphicsDevice.ResourceFactory.CreateBuffer(
                        bufferDescriptionFactory.Create(
                            (uint)(maximumInstancesPerDraw * Unsafe.SizeOf<LineInstance>()),
                            BufferUsage.StructuredBufferReadOnly,
                            (uint)(Unsafe.SizeOf<LineInstance>()))));
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