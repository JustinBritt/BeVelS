namespace BeVelS.Graphics.Shapes.InterfacesFactories
{
    using BepuPhysics;
    using BepuPhysics.Collidables;

    using BeVelS.Graphics.Shapes.Structs;

    public interface ISphereInstanceFactory
    {
        SphereInstance Create(
            RigidPose pose,
            Sphere sphere);
    }
}