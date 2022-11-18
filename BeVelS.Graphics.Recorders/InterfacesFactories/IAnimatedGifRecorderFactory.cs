namespace BeVelS.Graphics.Recorders.InterfacesFactories
{
    using BeVelS.Graphics.Recorders.Interfaces;

    public interface IAnimatedGifRecorderFactory
    {
        IAnimatedGifRecorder Create(
            int height,
            int width);
    }
}