namespace BeVelS.Graphics.Buffers.Factories
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.Buffers.Classes;
    using BeVelS.Graphics.Buffers.Interfaces;
    using BeVelS.Graphics.Buffers.InterfacesFactories;

    internal sealed class InstancesBufferFactory : IInstancesBufferFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InstancesBufferFactory()
        {
        }

        public IInstancesBuffer<T> Create<T>(
            DeviceBuffer deviceBuffer)
            where T : unmanaged
        {
            IInstancesBuffer<T> instancesBuffer = null;

            try
            {
                instancesBuffer = new InstancesBuffer<T>(
                    deviceBuffer);
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