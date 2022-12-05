namespace BeVelS.ECS.Systems.PlaybackEngines.Classes
{
    using DefaultEcs;

    using BeVelS.Audio.Caching.InterfacesFactories;
    using BeVelS.Audio.Channels.InterfacesFactories;
    using BeVelS.Audio.Mixers.InterfacesFactories;
    using BeVelS.Audio.PlaybackEngines.Interfaces;
    using BeVelS.Audio.PlaybackEngines.InterfacesFactories;
    using BeVelS.Audio.Players.InterfacesFactories;
    using BeVelS.Audio.Readers.InterfacesFactories;

    using BeVelS.ECS.Messages.PlaybackEngines.Structs;
    using BeVelS.ECS.Systems.PlaybackEngines.Interfaces;

    internal sealed class PlaybackEngineSystem : IPlaybackEngineSystem
    {
        public PlaybackEngineSystem(
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
            this.World = world;

            this.World.Subscribe(
                this);

            this.AudioPlaybackEngine16 = audioPlaybackEngine16Factory.Create(
                cachedSoundSampleProvider16Factory,
                monoToStereoSampleProviderFactory,
                mixingSampleProviderFactory,
                waveOutEventFactory,
                audioFileReaderFactory,
                autoDisposeAudioFileReaderFactory,
                volume,
                channelCount);
        }

        public bool IsEnabled { get; set; }

        public IAudioPlaybackEngine16 AudioPlaybackEngine16 { get; }

        private World World { get; }

        [Subscribe]
        private void On(
            in CachedSound16PlayMessage message)
        {
            this.AudioPlaybackEngine16.PlaySound(
                message.CachedSound16);
        }

        public void Update(
            float state)
        {
            if (this.IsEnabled)
            {
            }
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;
            }
        }
    }
}