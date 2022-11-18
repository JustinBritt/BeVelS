namespace BeVelS.ECS.Messages.Cameras.InterfacesFactories
{
    using System.Numerics;

    using BeVelS.ECS.Messages.Cameras.Structs;

    public interface ICameraSetPositionMessageFactory
    {
        CameraSetPositionMessage Create(
            Vector3 value);
    }
}