namespace BeVelS.Graphics.Shapes.InterfacesFactories
{
    using BepuPhysics;
    using BepuPhysics.Collidables;

    using BeVelS.Graphics.Shapes.Structs;

    public interface IBoxInstanceFactory
    {
        BoxInstance Create(
            Box box,
            RigidPose rigidPose);
    }
}