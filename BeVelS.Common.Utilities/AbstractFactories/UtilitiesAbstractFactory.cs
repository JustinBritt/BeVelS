namespace BeVelS.Common.Utilities.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Common.Utilities.Factories.Memory;
    using BeVelS.Common.Utilities.InterfacesAbstractFactories;
    using BeVelS.Common.Utilities.InterfacesFactories.Memory;

    public sealed class UtilitiesAbstractFactory : IUtilitiesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public UtilitiesAbstractFactory()
        {
        }

        public IBufferPoolFactory CreateBufferPoolFactory()
        {
            IBufferPoolFactory factory = null;

            try
            {
                factory = new BufferPoolFactory();
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