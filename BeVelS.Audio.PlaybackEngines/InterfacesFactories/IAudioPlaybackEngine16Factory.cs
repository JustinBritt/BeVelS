namespace BeVelS.Audio.PlaybackEngines.InterfacesFactories
{
    using BeVelS.Audio.Caching.InterfacesFactories;
    using BeVelS.Audio.Channels.InterfacesFactories;
    using BeVelS.Audio.Mixers.InterfacesFactories;
    using BeVelS.Audio.PlaybackEngines.Interfaces;
    using BeVelS.Audio.Players.InterfacesFactories;
    using BeVelS.Audio.Readers.InterfacesFactories;

    public interface IAudioPlaybackEngine16Factory
    {
        IAudioPlaybackEngine16 Create(
            ICachedSoundSampleProvider16Factory cachedSoundSampleProvider16Factory,
            IMonoToStereoSampleProviderFactory monoToStereoSampleProviderFactory,
            IMixingSampleProviderFactory mixingSampleProviderFactory,
            IWaveOutEventFactory waveOutEventFactory,
            IAudioFileReaderFactory audioFileReaderFactory,
            IAutoDisposeAudioFileReaderFactory autoDisposeAudioFileReaderFactory,
            float volume,
            int channelCount = 2);
    }
}