namespace BeVelS.ECS.Messages.PlaybackEngines.InterfacesFactories
{
    using BeVelS.Audio.Caching.Interfaces;

    using BeVelS.ECS.Messages.PlaybackEngines.Structs;

    public interface ICachedSound16PlayMessageFactory
    {
        CachedSound16PlayMessage Create(
            ICachedSound16 cachedSound16);
    }
}