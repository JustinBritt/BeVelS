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

    internal sealed class BoxInstancesBufferFactory : IBoxInstancesBufferFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BoxInstancesBufferFactory()
        {
        }

        public unsafe IShapeInstancesBuffer<BoxInstance> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            int maximumInstancesPerDraw)
        {
            IShapeInstancesBuffer<BoxInstance> shapeInstancesBuffer = null;

            try
            {
                shapeInstancesBuffer = new ShapeInstancesBuffer<BoxInstance>(
                    graphicsDevice.ResourceFactory.CreateBuffer(
                        bufferDescriptionFactory.Create(
                            (uint)(maximumInstancesPerDraw * Unsafe.SizeOf<BoxInstance>()),
                            BufferUsage.StructuredBufferReadOnly,
                            (uint)(Unsafe.SizeOf<BoxInstance>()))));
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