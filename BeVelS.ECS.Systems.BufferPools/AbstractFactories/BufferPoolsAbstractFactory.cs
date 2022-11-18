namespace BeVelS.ECS.Systems.BufferPools.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Systems.BufferPools.Factories;
    using BeVelS.ECS.Systems.BufferPools.InterfacesAbstractFactories;
    using BeVelS.ECS.Systems.BufferPools.InterfacesFactories;

    public sealed class BufferPoolsAbstractFactory : IBufferPoolsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BufferPoolsAbstractFactory()
        {
        }

        public IBufferPoolSystemFactory CreateBufferPoolSystemFactory()
        {
            IBufferPoolSystemFactory factory = null;

            try
            {
                factory = new BufferPoolSystemFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}