namespace BeVelS.Graphics.Buffers.Factories
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.Buffers.Classes;
    using BeVelS.Graphics.Buffers.Interfaces;
    using BeVelS.Graphics.Buffers.InterfacesFactories;

    internal sealed class ConstantsBufferFactory : IConstantsBufferFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConstantsBufferFactory()
        {
        }

        public IConstantsBuffer<T> Create<T>(
            DeviceBuffer deviceBuffer)
            where T : unmanaged
        {
            IConstantsBuffer<T> constantsBuffer = null;

            try
            {
                constantsBuffer = new ConstantsBuffer<T>(
                    deviceBuffer);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return constantsBuffer;
        }
    }
}