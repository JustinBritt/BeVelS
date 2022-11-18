namespace BeVelS.Graphics.Shapes.InterfacesFactories
{
    using System.Numerics;

    using BepuPhysics;
    using BepuPhysics.Collidables;

    using BeVelS.Graphics.Shapes.Structs;

    public interface ICylinderInstanceFactory
    {
        CylinderInstance Create(
            float halfLength,
            Quaternion orientation,
            Vector3 position,
            float radius);

        CylinderInstance Create(
            Cylinder cylinder,
            RigidPose rigidPose);
    }
}