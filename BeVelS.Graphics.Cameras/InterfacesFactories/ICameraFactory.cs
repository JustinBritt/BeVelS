namespace BeVelS.Graphics.Cameras.InterfacesFactories
{
    using BeVelS.Graphics.Cameras.Interfaces;

    public interface ICameraFactory
    {
        ICamera Create(
            float aspectRatio,
            float fieldOfView,
            float nearClip,
            float farClip);
    }
}