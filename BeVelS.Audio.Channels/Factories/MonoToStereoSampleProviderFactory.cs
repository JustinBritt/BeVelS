namespace BeVelS.Audio.Channels.Factories
{
    using System;

    using log4net;

    using NAudio.Wave;
    using NAudio.Wave.SampleProviders;

    using BeVelS.Audio.Channels.InterfacesFactories;
    
    internal sealed class MonoToStereoSampleProviderFactory : IMonoToStereoSampleProviderFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MonoToStereoSampleProviderFactory()
        {
        }

        public MonoToStereoSampleProvider Create(
            ISampleProvider source)
        {
            MonoToStereoSampleProvider monoToStereoSampleProvider = null;

            try
            {
                monoToStereoSampleProvider = new MonoToStereoSampleProvider(
                    source);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return monoToStereoSampleProvider;
        }
    }
}