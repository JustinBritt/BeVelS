namespace BeVelS.Audio.Readers.InterfacesFactories
{
    using NAudio.Wave;

    using BeVelS.Audio.Readers.Interfaces;

    public interface IAutoDisposeAudioFileReaderFactory
    {
        IAutoDisposeAudioFileReader Create(
            AudioFileReader audioFileReader);
    }
}