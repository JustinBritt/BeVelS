namespace BeVelS.Audio.Mixers.InterfacesFactories
{
    using NAudio.Wave;
    using NAudio.Wave.SampleProviders;

    public interface IMixingSampleProviderFactory
    {
        MixingSampleProvider Create(
            WaveFormat waveFormat);
    }
}