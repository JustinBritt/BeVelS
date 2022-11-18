namespace BeVelS.Graphics.Buffers.Factories.ShapeInstances
{
    using System;
    using System.Runtime.CompilerServices;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.Buffers.Classes;
    using BeVelS.Graphics.Buffers.Interfaces;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Buffers.InterfacesFactories.ShapeInstances;
    using BeVelS.Graphics.Shapes.Structs;

    internal sealed class CapsuleInstancesBufferFactory : ICapsuleInstancesBufferFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CapsuleInstancesBufferFactory()
        {
        }

        public unsafe IShapeInstancesBuffer<CapsuleInstance> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            int maximumInstancesPerDraw)
        {
            IShapeInstancesBuffer<CapsuleInstance> shapeInstancesBuffer = null;

            try
            {
                shapeInstancesBuffer = new ShapeInstancesBuffer<CapsuleInstance>(
                    graphicsDevice.ResourceFactory.CreateBuffer(
                        bufferDescriptionFactory.Create(
                            (uint)(maximumInstancesPerDraw * Unsafe.SizeOf<CapsuleInstance>()),
                            BufferUsage.StructuredBufferReadOnly,
                            (uint)(Unsafe.SizeOf<CapsuleInstance>()))));
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return shapeInstancesBuffer;
        }
    }
}