namespace BeVelS.Common.Utilities.Factories.Memory
{
    using System;

    using log4net;

    using BepuUtilities.Memory;

    using BeVelS.Common.Utilities.InterfacesFactories.Memory;

    internal sealed class BufferPoolFactory : IBufferPoolFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BufferPoolFactory()
        {
        }

        public IUnmanagedMemoryPool Create()
        {
            IUnmanagedMemoryPool bufferPool = default;

            try
            {
                bufferPool = new BufferPool();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return bufferPool;
        }
    }
}