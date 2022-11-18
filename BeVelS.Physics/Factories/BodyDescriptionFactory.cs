namespace BeVelS.Physics.Factories
{
    using System;

    using BepuPhysics;
    using BepuPhysics.Collidables;

    using BeVelS.Physics.InterfacesFactories;

    internal sealed class BodyDescriptionFactory : IBodyDescriptionFactory
    {
        public BodyDescriptionFactory()
        {
        }

        public BodyDescription Create(
            BodyActivityDescription bodyActivityDescription,
            BodyVelocity bodyVelocity,
            CollidableDescription collidableDescription,
            CollidableMobility collidableMobility,
            IShape shape,
            RigidPose rigidPose,
            BodyInertia bodyInertia = default)
        {
            return collidableMobility switch
            {
                CollidableMobility.Dynamic => BodyDescription.CreateDynamic(
                    pose: rigidPose,
                    velocity: bodyVelocity,
                    inertia: bodyInertia,
                    collidable: collidableDescription,
                    activity: bodyActivityDescription),

                CollidableMobility.Kinematic => BodyDescription.CreateKinematic(
                    pose: rigidPose,
                    velocity: bodyVelocity,
                    collidable: collidableDescription,
                    activity: bodyActivityDescription),

                { } => throw new ArgumentException(nameof(collidableMobility))
            };
        }
    }
}