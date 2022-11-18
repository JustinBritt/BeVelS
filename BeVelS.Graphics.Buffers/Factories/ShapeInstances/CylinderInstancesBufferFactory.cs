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

    internal sealed class CylinderInstancesBufferFactory : ICylinderInstancesBufferFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CylinderInstancesBufferFactory()
        {
        }

        public unsafe IShapeInstancesBuffer<CylinderInstance> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            int maximumInstancesPerDraw)
        {
            IShapeInstancesBuffer<CylinderInstance> shapeInstancesBuffer = null;

            try
            {
                shapeInstancesBuffer = new ShapeInstancesBuffer<CylinderInstance>(
                    graphicsDevice.ResourceFactory.CreateBuffer(
                        bufferDescriptionFactory.Create(
                            (uint)(maximumInstancesPerDraw * Unsafe.SizeOf<CylinderInstance>()),
                            BufferUsage.StructuredBufferReadOnly,
                            (uint)(Unsafe.SizeOf<CylinderInstance>()))));
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