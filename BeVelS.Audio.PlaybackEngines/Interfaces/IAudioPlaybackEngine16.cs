namespace BeVelS.Audio.PlaybackEngines.Interfaces
{
    using System;

    using BeVelS.Audio.Caching.Interfaces;

    public interface IAudioPlaybackEngine16 : IDisposable
    {
        void PlaySound(
            ICachedSound16 cachedSound16);

        void PlaySound(
            string fileName);
    }
}