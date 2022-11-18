namespace BeVelS.Graphics.Shapes.InterfacesFactories
{
    using BepuPhysics;
    using BepuPhysics.Collidables;

    using BeVelS.Graphics.Shapes.Structs;

    public interface ICompoundInstanceFactory
    {
        CompoundInstance Create(
            Compound compound,
            RigidPose rigidPose);
    }
}