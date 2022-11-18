namespace BeVelS.Audio.Readers.Classes
{
    using NAudio.Wave;

    using BeVelS.Audio.Readers.Interfaces;

    using BeVelS.Licensing.Classes;

    [NAudioLicensedCode(
        boilerplate: NAudioLicensedCodeAttribute.MITLicenseBoilerplate,
        copyrightOwner: NAudioLicensedCodeAttribute.NAudioCopyrightOwner,
        copyrightYears: NAudioLicensedCodeAttribute.NAudioCopyrightYears,
        source: "https://github.com/naudio/NAudio/blob/master/NAudio.Extras/AutoDisposeFileReader.cs")]
    internal sealed class AutoDisposeAudioFileReader : IAutoDisposeAudioFileReader
    {
        public AutoDisposeAudioFileReader(
            AudioFileReader audioFileReader)
        {
            this.AudioFileReader = audioFileReader;

            this.WaveFormat = this.AudioFileReader.WaveFormat;
        }

        private AudioFileReader AudioFileReader { get; }

        private bool IsDisposed { get; set; }

        public WaveFormat WaveFormat { get; }

        public int Read(
            float[] buffer,
            int offset,
            int count)
        {
            if (this.IsDisposed)
            {
                return 0;
            }

            int read = this.AudioFileReader.Read(
                buffer,
                offset,
                count);

            if (read == 0)
            {
                this.AudioFileReader.Dispose();

                this.IsDisposed = true;
            }

            return read;
        }
    }
}