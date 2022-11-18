namespace BeVelS.ECS.Components.CollidableShapes.InterfacesFactories
{
    using System.Numerics;

    using BepuPhysics;
    using BepuPhysics.Collidables;

    using BeVelS.ECS.Components.CollidableShapes.Structs;

    using BeVelS.Physics.Collidables.InterfacesFactories;
    using BeVelS.Physics.InterfacesFactories;

    public interface ICollidableShapeComponentFactory
    {
        CollidableShapeComponent Create(
            IBodyActivityDescriptionFactory bodyActivityDescriptionFactory,
            IBodyDescriptionFactory bodyDescriptionFactory,
            IBodyInertiaFactory bodyInertiaFactory,
            IBodyVelocityFactory bodyVelocityFactory,
            IRigidPoseFactory rigidPoseFactory,
            IStaticDescriptionFactory staticDescriptionFactory,
            ICollidableDescriptionFactory collidableDescriptionFactory,
            ICollidableReferenceFactory collidableReferenceFactory,
            Vector3 angularVelocity,
            CollidableMobility collidableMobility,
            ContinuousDetection continuousDetection,
            Vector3 linearVelocity,
            float mass,
            float maximumSpeculativeMargin,
            float minimumSpeculativeMargin,
            Vector3 position,
            IShape shape,
            Simulation simulation,
            float sleepThreshold);
    }
}