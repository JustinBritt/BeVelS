namespace BeVelS.Audio.Resamplers.Factories
{
    using System;

    using log4net;

    using NAudio.Wave;
    using NAudio.Wave.SampleProviders;

    using BeVelS.Audio.Resamplers.InterfacesFactories;

    internal sealed class WdlResamplingSampleProviderFactory : IWdlResamplingSampleProviderFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WdlResamplingSampleProviderFactory()
        {
        }

        public ISampleProvider Create(
            int newSampleRate,
            ISampleProvider source)
        {
            ISampleProvider wdlResamplingSampleProvider = null;

            try
            {
                wdlResamplingSampleProvider = new WdlResamplingSampleProvider(
                    source: source,
                    newSampleRate: newSampleRate);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return wdlResamplingSampleProvider;
        }
    }
}