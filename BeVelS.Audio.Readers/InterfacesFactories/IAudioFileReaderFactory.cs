namespace BeVelS.Audio.Readers.InterfacesFactories
{
    using NAudio.Wave;

    public interface IAudioFileReaderFactory
    {
        AudioFileReader Create(
            string fileName);
    }
}