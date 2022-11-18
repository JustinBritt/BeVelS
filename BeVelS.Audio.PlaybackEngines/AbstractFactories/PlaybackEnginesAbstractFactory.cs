namespace BeVelS.Audio.PlaybackEngines.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Audio.PlaybackEngines.Factories;
    using BeVelS.Audio.PlaybackEngines.InterfacesAbstractFactories;
    using BeVelS.Audio.PlaybackEngines.InterfacesFactories;

    public sealed class PlaybackEnginesAbstractFactory : IPlaybackEnginesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PlaybackEnginesAbstractFactory()
        {
        }

        public IAudioPlaybackEngine16Factory CreateAudioPlaybackEngine16Factory()
        {
            IAudioPlaybackEngine16Factory factory = null;

            try
            {
                factory = new AudioPlaybackEngine16Factory();
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