namespace BeVelS.ECS.Messages.Cameras.InterfacesAbstractFactories
{
    using BeVelS.ECS.Messages.Cameras.InterfacesFactories;

    public interface ICamerasAbstractFactory
    {
        ICameraSetPositionMessageFactory CreateCameraSetPositionMessageFactory();
    }
}