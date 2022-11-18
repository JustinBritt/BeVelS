namespace BeVelS.ECS.Components.Cameras.InterfacesAbstractFactories
{
    using BeVelS.ECS.Components.Cameras.InterfacesFactories;

    public interface ICamerasAbstractFactory
    {
        ICameraComponentFactory CreateCameraComponentFactory();
    }
}