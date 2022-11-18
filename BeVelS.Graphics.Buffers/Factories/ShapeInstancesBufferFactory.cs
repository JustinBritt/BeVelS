namespace BeVelS.Graphics.Buffers.Factories
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.Buffers.Classes;
    using BeVelS.Graphics.Buffers.Interfaces;
    using BeVelS.Graphics.Buffers.InterfacesFactories;

    internal sealed class ShapeInstancesBufferFactory : IShapeInstancesBufferFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ShapeInstancesBufferFactory()
        {
        }

        public IShapeInstancesBuffer<T> Create<T>(
            DeviceBuffer deviceBuffer)
            where T : unmanaged
        {
            IShapeInstancesBuffer<T> shapeInstancesBuffer = null;

            try
            {
                shapeInstancesBuffer = new ShapeInstancesBuffer<T>(
                    deviceBuffer);
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