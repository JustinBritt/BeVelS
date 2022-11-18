namespace BeVelS.Audio.Readers.InterfacesAbstractFactories
{
    using BeVelS.Audio.Readers.InterfacesFactories;

    public interface IReadersAbstractFactory
    {
        IAudioFileReaderFactory CreateAudioFileReaderFactory();

        IAutoDisposeAudioFileReaderFactory CreateAutoDisposeAudioFileReaderFactory();
    }
}