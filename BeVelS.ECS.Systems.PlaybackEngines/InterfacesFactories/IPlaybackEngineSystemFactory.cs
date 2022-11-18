namespace BeVelS.ECS.Systems.PlaybackEngines.InterfacesFactories
{
    using DefaultEcs;

    using BeVelS.Audio.Caching.InterfacesFactories;
    using BeVelS.Audio.Channels.InterfacesFactories;
    using BeVelS.Audio.Mixers.InterfacesFactories;
    using BeVelS.Audio.PlaybackEngines.InterfacesFactories;
    using BeVelS.Audio.Players.InterfacesFactories;
    using BeVelS.Audio.Readers.InterfacesFactories;

    using BeVelS.ECS.Systems.PlaybackEngines.Interfaces;

    public interface IPlaybackEngineSystemFactory
    {
        IPlaybackEngineSystem Create(
            ICachedSoundSampleProvider16Factory cachedSoundSampleProvider16Factory,
            IMonoToStereoSampleProviderFactory monoToStereoSampleProviderFactory,
            IMixingSampleProviderFactory mixingSampleProviderFactory,
            IAudioPlaybackEngine16Factory audioPlaybackEngine16Factory,
            IWaveOutEventFactory waveOutEventFactory,
            IAudioFileReaderFactory audioFileReaderFactory,
            IAutoDisposeAudioFileReaderFactory autoDisposeAudioFileReaderFactory,
            float volume,
            World world,
            int channelCount = 2);
    }
}