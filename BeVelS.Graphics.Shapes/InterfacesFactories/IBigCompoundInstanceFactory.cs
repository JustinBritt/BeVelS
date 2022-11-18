namespace BeVelS.Graphics.Shapes.InterfacesFactories
{
    using BepuPhysics;
    using BepuPhysics.Collidables;

    using BeVelS.Graphics.Shapes.Structs;

    public interface IBigCompoundInstanceFactory
    {
        BigCompoundInstance Create(
            BigCompound bigCompound,
            RigidPose rigidPose);
    }
}