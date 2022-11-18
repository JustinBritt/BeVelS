namespace BeVelS.ECS.Components.Cameras.InterfacesFactories
{
    using BeVelS.ECS.Components.Cameras.Structs;

    using BeVelS.Graphics.Cameras.Interfaces;

    public interface ICameraComponentFactory
    {
        CameraComponent Create(
            ICamera value);
    }
}