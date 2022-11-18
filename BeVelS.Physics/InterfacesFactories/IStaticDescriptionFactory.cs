namespace BeVelS.Physics.InterfacesFactories
{
    using System.Numerics;

    using BepuPhysics;
    using BepuPhysics.Collidables;

    public interface IStaticDescriptionFactory
    {
        StaticDescription Create(
            RigidPose rigidPose,
            TypedIndex shape);
    }
}