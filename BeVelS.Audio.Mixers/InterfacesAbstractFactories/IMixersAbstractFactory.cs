namespace BeVelS.Audio.Mixers.InterfacesAbstractFactories
{
    using BeVelS.Audio.Mixers.InterfacesFactories;

    public interface IMixersAbstractFactory
    {
        IMixingSampleProviderFactory CreateMixingSampleProviderFactory();
    }
}