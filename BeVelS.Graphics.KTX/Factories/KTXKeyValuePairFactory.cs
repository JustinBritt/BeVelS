namespace BeVelS.Graphics.KTX.Factories
{
    using System;

    using log4net;

    using BeVelS.Graphics.KTX.Classes;
    using BeVelS.Graphics.KTX.Interfaces;
    using BeVelS.Graphics.KTX.InterfacesFactories;

    internal sealed class KTXKeyValuePairFactory : IKTXKeyValuePairFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public KTXKeyValuePairFactory()
        {
        }

        public IKTXKeyValuePair Create(
            string key,
            byte[] value)
        {
            IKTXKeyValuePair KTXKeyValuePair = null;

            try
            {
                KTXKeyValuePair = new KTXKeyValuePair(
                    key,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return KTXKeyValuePair;
        }
    }
}