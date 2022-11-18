namespace BeVelS.Graphics.Shapes.InterfacesFactories
{
    using BepuPhysics;
    using BepuPhysics.Collidables;

    using BeVelS.Graphics.Shapes.Structs;

    public interface ITriangleInstanceFactory
    {
        TriangleInstance Create(
            RigidPose rigidPose,
            Triangle triangle);
    }
}