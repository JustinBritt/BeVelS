namespace BeVelS.Physics.InterfacesFactories
{
    using System.Numerics;

    using BepuPhysics;

    public interface IRigidPoseFactory
    {
        RigidPose Create(
            Vector3 position);

        RigidPose Create(
            Quaternion orientation,
            Vector3 position);
    }
}