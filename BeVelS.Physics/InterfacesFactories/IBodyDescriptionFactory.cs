namespace BeVelS.Physics.InterfacesFactories
{
    using BepuPhysics;
    using BepuPhysics.Collidables;

    public interface IBodyDescriptionFactory
    {
        BodyDescription Create(
            BodyActivityDescription bodyActivityDescription,
            BodyVelocity bodyVelocity,
            CollidableDescription collidableDescription,
            CollidableMobility collidableMobility,
            IShape shape,
            RigidPose rigidPose,
            BodyInertia bodyInertia = default);
    }
}