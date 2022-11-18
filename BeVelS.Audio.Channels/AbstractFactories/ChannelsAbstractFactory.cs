namespace BeVelS.Audio.Channels.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Audio.Channels.Factories;
    using BeVelS.Audio.Channels.InterfacesAbstractFactories;
    using BeVelS.Audio.Channels.InterfacesFactories;

    public sealed class ChannelsAbstractFactory : IChannelsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ChannelsAbstractFactory()
        {
        }

        public IMonoToStereoSampleProviderFactory CreateMonoToStereoSampleProviderFactory()
        {
            IMonoToStereoSampleProviderFactory factory = null;

            try
            {
                factory = new MonoToStereoSampleProviderFactory();
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