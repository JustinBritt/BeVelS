namespace BeVelS.ECS.Systems.BufferPools.Factories
{
    using System;

    using log4net;

    using DefaultEcs;

    using BeVelS.Common.Utilities.InterfacesFactories.Memory;

    using BeVelS.ECS.Systems.BufferPools.Classes;
    using BeVelS.ECS.Systems.BufferPools.Interfaces;
    using BeVelS.ECS.Systems.BufferPools.InterfacesFactories;

    internal sealed class BufferPoolSystemFactory : IBufferPoolSystemFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BufferPoolSystemFactory()
        {
        }

        public IBufferPoolSystem Create(
            IBufferPoolFactory bufferPoolFactory,
            World world)
        {
            IBufferPoolSystem system = null;

            try
            {
                system = new BufferPoolSystem(
                    bufferPoolFactory,
                    world);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return system;
        }
    }
}