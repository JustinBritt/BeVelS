namespace BeVelS.Audio.Channels.InterfacesFactories
{
    using NAudio.Wave;
    using NAudio.Wave.SampleProviders;

    public interface IMonoToStereoSampleProviderFactory
    {
        MonoToStereoSampleProvider Create(
            ISampleProvider source);
    }
}