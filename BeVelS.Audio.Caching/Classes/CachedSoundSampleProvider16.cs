namespace BeVelS.Audio.Caching.Classes
{
    using System;

    using NAudio.Wave;

    using BeVelS.Audio.Caching.Interfaces;

    using BeVelS.Licensing.Classes;

    [NAudioLicensedCode(
        boilerplate: NAudioLicensedCodeAttribute.MITLicenseBoilerplate,
        copyrightOwner: NAudioLicensedCodeAttribute.NAudioCopyrightOwner,
        copyrightYears: NAudioLicensedCodeAttribute.NAudioCopyrightYears,
        source: "https://github.com/naudio/NAudio/blob/master/NAudio.Extras/CachedSoundSampleProvider.cs")]
    internal sealed class CachedSoundSampleProvider16 : ICachedSoundSampleProvider16
    {
        private readonly ICachedSound16 cachedSound16;

        private long position;

        public CachedSoundSampleProvider16(
            ICachedSound16 cachedSound16)
        {
            this.cachedSound16 = cachedSound16;
        }

        public int Read(
            float[] buffer,
            int offset,
            int count)
        {
            long availableSamples = this.cachedSound16.AudioData.Length - this.position;

            long samplesToCopy = Math.Min(
                availableSamples,
                count);

            Array.Copy(
                this.cachedSound16.AudioData,
                this.position,
                buffer,
                offset,
                samplesToCopy);

            this.position += samplesToCopy;

            return (int)samplesToCopy;
        }

        public WaveFormat WaveFormat => cachedSound16.WaveFormat;
    }
}
