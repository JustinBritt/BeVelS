namespace BeVelS.Audio.Caching.InterfacesAbstractFactories
{
    using BeVelS.Audio.Caching.InterfacesFactories;

    public interface ICachingAbstractFactory
    {
        ICachedSound16Factory CreateCachedSound16Factory();

        ICachedSoundSampleProvider16Factory CreateCachedSoundSampleProvider16Factory();
    }
}