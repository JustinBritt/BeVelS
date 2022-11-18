namespace BeVelS.Audio.Caching.Interfaces
{
    using NAudio.Wave;

    public interface ICachedSound16
    {
        float[] AudioData { get;  }

        WaveFormat WaveFormat { get; }
    }
}