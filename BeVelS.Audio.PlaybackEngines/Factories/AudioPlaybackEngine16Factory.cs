namespace BeVelS.Audio.PlaybackEngines.Factories
{
    using System;

    using log4net;

    using BeVelS.Audio.Caching.InterfacesFactories;
    using BeVelS.Audio.Channels.InterfacesFactories;
    using BeVelS.Audio.Mixers.InterfacesFactories;
    using BeVelS.Audio.PlaybackEngines.Classes;
    using BeVelS.Audio.PlaybackEngines.Interfaces;
    using BeVelS.Audio.PlaybackEngines.InterfacesFactories;
    using BeVelS.Audio.Players.InterfacesFactories;
    using BeVelS.Audio.Readers.InterfacesFactories;

    internal sealed class AudioPlaybackEngine16Factory : IAudioPlaybackEngine16Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AudioPlaybackEngine16Factory()
        {
        }

        public IAudioPlaybackEngine16 Create(
            ICachedSoundSampleProvider16Factory cachedSoundSampleProvider16Factory,
            IMonoToStereoSampleProviderFactory monoToStereoSampleProviderFactory,
            IMixingSampleProviderFactory mixingSampleProviderFactory,
            IWaveOutEventFactory waveOutEventFactory,
            IAudioFileReaderFactory audioFileReaderFactory,
            IAutoDisposeAudioFileReaderFactory autoDisposeAudioFileReaderFactory,
            float volume,
            int channelCount = 2)
        {
            IAudioPlaybackEngine16 audioPlaybackEngine16 = null;

            try
            {
                audioPlaybackEngine16 = new AudioPlaybackEngine16(
                    cachedSoundSampleProvider16Factory,
                    monoToStereoSampleProviderFactory,
                    mixingSampleProviderFactory,
                    waveOutEventFactory,
                    audioFileReaderFactory,
                    autoDisposeAudioFileReaderFactory,
                    volume,
                    channelCount);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return audioPlaybackEngine16;
        }
    }
}