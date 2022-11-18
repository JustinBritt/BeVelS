namespace BeVelS.Audio.PlaybackEngines.Classes
{
    using System;

    using NAudio.Wave;
    using NAudio.Wave.SampleProviders;

    using BeVelS.Audio.Caching.Interfaces;
    using BeVelS.Audio.Caching.InterfacesFactories;
    using BeVelS.Audio.Channels.InterfacesFactories;
    using BeVelS.Audio.Mixers.InterfacesFactories;
    using BeVelS.Audio.PlaybackEngines.Interfaces;
    using BeVelS.Audio.Players.InterfacesFactories;
    using BeVelS.Audio.Readers.InterfacesFactories;

    using BeVelS.Licensing.Classes;

    [NAudioLicensedCode(
        boilerplate: NAudioLicensedCodeAttribute.MITLicenseBoilerplate,
        copyrightOwner: NAudioLicensedCodeAttribute.NAudioCopyrightOwner,
        copyrightYears: NAudioLicensedCodeAttribute.NAudioCopyrightYears,
        source: "https://github.com/naudio/NAudio/blob/master/NAudio.Extras/AudioPlaybackEngine.cs")]
    internal sealed class AudioPlaybackEngine16 : IAudioPlaybackEngine16
    {
        private const int sampleRate = 16000;

        private readonly IWavePlayer outputDevice;

        private readonly MixingSampleProvider mixer;

        public AudioPlaybackEngine16(
            ICachedSoundSampleProvider16Factory cachedSoundSampleProvider16Factory,
            IMonoToStereoSampleProviderFactory monoToStereoSampleProviderFactory,
            IMixingSampleProviderFactory mixingSampleProviderFactory,
            IWaveOutEventFactory waveOutEventFactory,
            IAudioFileReaderFactory audioFileReaderFactory,
            IAutoDisposeAudioFileReaderFactory autoDisposeAudioFileReaderFactory,
            float volume,
            int channelCount = 2)
        {
            this.CachedSoundSampleProvider16Factory = cachedSoundSampleProvider16Factory;

            this.MonoToStereoSampleProviderFactory = monoToStereoSampleProviderFactory;

            this.AudioFileReaderFactory = audioFileReaderFactory;

            this.AutoDisposeAudioFileReaderFactory = autoDisposeAudioFileReaderFactory;

            this.outputDevice = waveOutEventFactory.Create();

            this.mixer = mixingSampleProviderFactory.Create(
                WaveFormat.CreateIeeeFloatWaveFormat(
                    sampleRate,
                    channelCount));

            this.mixer.ReadFully = true;

            this.outputDevice.Init(
                this.mixer);

            this.outputDevice.Volume = volume;

            this.outputDevice.Play();
        }

        private ICachedSoundSampleProvider16Factory CachedSoundSampleProvider16Factory { get; }

        private IMonoToStereoSampleProviderFactory MonoToStereoSampleProviderFactory { get; }

        private IAudioFileReaderFactory AudioFileReaderFactory { get; }

        private IAutoDisposeAudioFileReaderFactory AutoDisposeAudioFileReaderFactory { get; }

        private void AddMixerInput(
            ISampleProvider input)
        {
            this.mixer.AddMixerInput(
                this.ConvertToRightChannelCount(
                    input));
        }

        private ISampleProvider ConvertToRightChannelCount(
            ISampleProvider input)
        {
            if (input.WaveFormat.Channels == this.mixer.WaveFormat.Channels)
            {
                return input;
            }

            if (input.WaveFormat.Channels == 1 && this.mixer.WaveFormat.Channels == 2)
            {
                return this.MonoToStereoSampleProviderFactory.Create(
                    input);
            }

            throw new NotImplementedException(
                "Not yet implemented this channel count conversion");
        }

        public void PlaySound(
            ICachedSound16 cachedSound16)
        {
            this.AddMixerInput(
                this.CachedSoundSampleProvider16Factory.Create(
                    cachedSound16));
        }

        public void PlaySound(
            string fileName)
        {
            this.AddMixerInput(
                this.AutoDisposeAudioFileReaderFactory.Create(
                    this.AudioFileReaderFactory.Create(
                        fileName)));
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                this.outputDevice.Dispose();
            }
        }
    }
}