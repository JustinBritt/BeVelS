namespace BeVelS.Audio.Readers.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Audio.Readers.Factories;
    using BeVelS.Audio.Readers.InterfacesAbstractFactories;
    using BeVelS.Audio.Readers.InterfacesFactories;

    public sealed class ReadersAbstractFactory : IReadersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ReadersAbstractFactory()
        {
        }

        public IAudioFileReaderFactory CreateAudioFileReaderFactory()
        {
            IAudioFileReaderFactory factory = null;

            try
            {
                factory = new AudioFileReaderFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IAutoDisposeAudioFileReaderFactory CreateAutoDisposeAudioFileReaderFactory()
        {
            IAutoDisposeAudioFileReaderFactory factory = null;

            try
            {
                factory = new AutoDisposeAudioFileReaderFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}