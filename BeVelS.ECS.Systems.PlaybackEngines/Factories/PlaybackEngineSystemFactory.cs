namespace BeVelS.ECS.Systems.PlaybackEngines.Factories
{
    using System;

    using log4net;

    using DefaultEcs;

    using BeVelS.Audio.Caching.InterfacesFactories;
    using BeVelS.Audio.Channels.InterfacesFactories;
    using BeVelS.Audio.Mixers.InterfacesFactories;
    using BeVelS.Audio.PlaybackEngines.InterfacesFactories;
    using BeVelS.Audio.Players.InterfacesFactories;
    using BeVelS.Audio.Readers.InterfacesFactories;

    using BeVelS.ECS.Systems.PlaybackEngines.Classes;
    using BeVelS.ECS.Systems.PlaybackEngines.Interfaces;
    using BeVelS.ECS.Systems.PlaybackEngines.InterfacesFactories;
    
    internal sealed class PlaybackEngineSystemFactory : IPlaybackEngineSystemFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PlaybackEngineSystemFactory()
        {
        }

        public IPlaybackEngineSystem Create(
            ICachedSoundSampleProvider16Factory cachedSoundSampleProvider16Factory,
            IMonoToStereoSampleProviderFactory monoToStereoSampleProviderFactory,
            IMixingSampleProviderFactory mixingSampleProviderFactory,
            IAudioPlaybackEngine16Factory audioPlaybackEngine16Factory,
            IWaveOutEventFactory waveOutEventFactory,
            IAudioFileReaderFactory audioFileReaderFactory,
            IAutoDisposeAudioFileReaderFactory autoDisposeAudioFileReaderFactory,
            float volume,
            World world,
            int channelCount = 2)
        {
            IPlaybackEngineSystem playbackEngineSystem = null;

            try
            {
                playbackEngineSystem = new PlaybackEngineSystem(
                    cachedSoundSampleProvider16Factory,
                    monoToStereoSampleProviderFactory,
                    mixingSampleProviderFactory,
                    audioPlaybackEngine16Factory,
                    waveOutEventFactory,
                    audioFileReaderFactory,
                    autoDisposeAudioFileReaderFactory,
                    volume,
                    world,
                    channelCount);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return playbackEngineSystem;
        }
    }
}