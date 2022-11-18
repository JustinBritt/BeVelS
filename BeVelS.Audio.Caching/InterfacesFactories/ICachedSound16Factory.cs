namespace BeVelS.Audio.Caching.InterfacesFactories
{
    using BeVelS.Audio.Caching.Interfaces;
    using BeVelS.Audio.Readers.InterfacesFactories;
    using BeVelS.Audio.Resamplers.InterfacesFactories;

    public interface ICachedSound16Factory
    {
        ICachedSound16 Create(
            IAudioFileReaderFactory audioFileReaderFactory,
            IWdlResamplingSampleProviderFactory wdlResamplingSampleProviderFactory,
            string audioFileName);
    }
}