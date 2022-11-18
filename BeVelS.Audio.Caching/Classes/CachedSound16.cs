namespace BeVelS.Audio.Caching.Classes
{
    using System.Collections.Generic;
    using System.Linq;

    using NAudio.Wave;

    using BeVelS.Audio.Caching.Interfaces;
    using BeVelS.Audio.Readers.InterfacesFactories;
    using BeVelS.Audio.Resamplers.InterfacesFactories;

    using BeVelS.Licensing.Classes;

    [NAudioLicensedCode(
        boilerplate: NAudioLicensedCodeAttribute.MITLicenseBoilerplate,
        copyrightOwner: NAudioLicensedCodeAttribute.NAudioCopyrightOwner,
        copyrightYears: NAudioLicensedCodeAttribute.NAudioCopyrightYears,
        source: "https://github.com/naudio/NAudio/blob/master/NAudio.Extras/CachedSound.cs")]
    internal sealed class CachedSound16 : ICachedSound16
    {
        private const int outRate = 16000;

        public CachedSound16(
            IAudioFileReaderFactory audioFileReaderFactory,
            IWdlResamplingSampleProviderFactory wdlResamplingSampleProviderFactory,
            string audioFileName)
        {
            using (AudioFileReader audioFileReader = audioFileReaderFactory.Create(audioFileName))
            {
                ISampleProvider sampleProvider = wdlResamplingSampleProviderFactory.Create(
                    outRate,
                    audioFileReader)
                    .ToWaveProvider16()
                    .ToSampleProvider();

                this.WaveFormat = sampleProvider.WaveFormat;

                List<float> wholeFile = new List<float>((int)(audioFileReader.Length / 4));

                float[] readBuffer = new float[sampleProvider.WaveFormat.SampleRate * sampleProvider.WaveFormat.Channels];

                int samplesRead;

                while ((samplesRead = sampleProvider.Read(readBuffer, 0, readBuffer.Length)) > 0)
                {
                    wholeFile.AddRange(
                        readBuffer.Take(
                            samplesRead));
                }

                this.AudioData = wholeFile.ToArray();
            }
        }

        public float[] AudioData { get; private set; }

        public WaveFormat WaveFormat { get; private set; }
    }
}