namespace BeVelS.Audio.Mixers.Factories
{
    using System;

    using log4net;

    using NAudio.Wave;
    using NAudio.Wave.SampleProviders;
    
    using BeVelS.Audio.Mixers.InterfacesFactories;
    
    internal sealed class MixingSampleProviderFactory : IMixingSampleProviderFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MixingSampleProviderFactory()
        {
        }

        public MixingSampleProvider Create(
            WaveFormat waveFormat)
        {
            MixingSampleProvider mixingSampleProvider = null;

            try
            {
                mixingSampleProvider = new MixingSampleProvider(
                    waveFormat);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return mixingSampleProvider;
        }
    }
}