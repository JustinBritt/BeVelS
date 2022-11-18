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

    internal sealed class SphereInstancesBufferFactory : ISphereInstancesBufferFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SphereInstancesBufferFactory()
        {
        }

        public unsafe IShapeInstancesBuffer<SphereInstance> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            int maximumInstancesPerDraw)
        {
            IShapeInstancesBuffer<SphereInstance> shapeInstancesBuffer = null;

            try
            {
                shapeInstancesBuffer = new ShapeInstancesBuffer<SphereInstance>(
                    graphicsDevice.ResourceFactory.CreateBuffer(
                        bufferDescriptionFactory.Create(
                            (uint)(maximumInstancesPerDraw * Unsafe.SizeOf<SphereInstance>()),
                            BufferUsage.StructuredBufferReadOnly,
                            (uint)(Unsafe.SizeOf<SphereInstance>()))));
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