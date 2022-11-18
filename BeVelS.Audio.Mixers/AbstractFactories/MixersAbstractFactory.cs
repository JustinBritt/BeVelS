namespace BeVelS.Audio.Mixers.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Audio.Mixers.Factories;
    using BeVelS.Audio.Mixers.InterfacesAbstractFactories;
    using BeVelS.Audio.Mixers.InterfacesFactories;

    public sealed class MixersAbstractFactory : IMixersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MixersAbstractFactory()
        {
        }

        public IMixingSampleProviderFactory CreateMixingSampleProviderFactory()
        {
            IMixingSampleProviderFactory factory = null;

            try
            {
                factory = new MixingSampleProviderFactory();
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