namespace BeVelS.ECS.Systems.Cameras.InterfacesAbstractFactories
{
    using BeVelS.ECS.Systems.Cameras.InterfacesFactories;

    public interface ICamerasAbstractFactory
    {
        ICameraSystemFactory CreateCameraSystemFactory();
    }
}