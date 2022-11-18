namespace BeVelS.Audio.Channels.InterfacesAbstractFactories
{
    using BeVelS.Audio.Channels.InterfacesFactories;

    public interface IChannelsAbstractFactory
    {
        IMonoToStereoSampleProviderFactory CreateMonoToStereoSampleProviderFactory();
    }
}