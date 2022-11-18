namespace BeVelS.Audio.Caching.InterfacesFactories
{
    using BeVelS.Audio.Caching.Interfaces;

    public interface ICachedSoundSampleProvider16Factory
    {
        ICachedSoundSampleProvider16 Create(
            ICachedSound16 cachedSound16);
    }
}