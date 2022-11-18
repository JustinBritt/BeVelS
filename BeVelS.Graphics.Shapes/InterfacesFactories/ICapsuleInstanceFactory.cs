namespace BeVelS.Graphics.Shapes.InterfacesFactories
{
    using BepuPhysics;
    using BepuPhysics.Collidables;

    using BeVelS.Graphics.Shapes.Structs;

    public interface ICapsuleInstanceFactory
    {
        CapsuleInstance Create(
            Capsule capsule,
            RigidPose rigidPose);
    }
}