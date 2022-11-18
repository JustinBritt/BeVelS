namespace BeVelS.Audio.Readers.Factories
{
    using System;

    using log4net;

    using NAudio.Wave;

    using BeVelS.Audio.Readers.Classes;
    using BeVelS.Audio.Readers.Interfaces;
    using BeVelS.Audio.Readers.InterfacesFactories;

    internal sealed class AutoDisposeAudioFileReaderFactory : IAutoDisposeAudioFileReaderFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AutoDisposeAudioFileReaderFactory()
        {
        }

        public IAutoDisposeAudioFileReader Create(
            AudioFileReader audioFileReader)
        {
            IAutoDisposeAudioFileReader autoDisposeAudioFileReader = null;

            try
            {
                autoDisposeAudioFileReader = new AutoDisposeAudioFileReader(
                    audioFileReader);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return autoDisposeAudioFileReader;
        }
    }
}