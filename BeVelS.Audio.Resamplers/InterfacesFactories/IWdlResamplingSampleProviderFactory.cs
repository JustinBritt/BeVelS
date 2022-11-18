namespace BeVelS.Audio.Resamplers.InterfacesFactories
{
    using NAudio.Wave;

    public interface IWdlResamplingSampleProviderFactory
    {
        ISampleProvider Create(
            int newSampleRate,
            ISampleProvider source);
    }
}