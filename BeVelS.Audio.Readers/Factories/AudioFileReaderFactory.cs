namespace BeVelS.Audio.Readers.Factories
{
    using System;

    using log4net;

    using NAudio.Wave;

    using BeVelS.Audio.Readers.InterfacesFactories;

    internal sealed class AudioFileReaderFactory : IAudioFileReaderFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AudioFileReaderFactory()
        {
        }

        public AudioFileReader Create(
            string fileName)
        {
            AudioFileReader audioFileReader = null;

            try
            {
                audioFileReader = new AudioFileReader(
                    fileName);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return audioFileReader;
        }
    }
}