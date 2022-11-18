namespace BeVelS.ECS.Components.CollidableShapes.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BepuPhysics;
    using BepuPhysics.Collidables;

    using BeVelS.ECS.Components.CollidableShapes.InterfacesFactories;
    using BeVelS.ECS.Components.CollidableShapes.Structs;

    using BeVelS.Physics.Collidables.Extensions;
    using BeVelS.Physics.Collidables.InterfacesFactories;
    using BeVelS.Physics.InterfacesFactories;

    internal sealed class CollidableShapeComponentFactory : ICollidableShapeComponentFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CollidableShapeComponentFactory()
        {
        }
        public CollidableShapeComponent Create(
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
            float sleepThreshold)
        {
            CollidableShapeComponent recorder = default;

            try
            {
                TypedIndex typedIndex = shape.AddToSimulation(
                    simulation);

                CollidableDescription collidableDescription = collidableDescriptionFactory.Create(
                    continuousDetection,
                    typedIndex,
                    maximumSpeculativeMargin,
                    minimumSpeculativeMargin);

                CollidableReference collidableReference = default;

                if (collidableMobility is CollidableMobility.Static)
                {
                    StaticDescription staticDescription = staticDescriptionFactory.Create(
                        rigidPose: rigidPoseFactory.Create(
                            position: position),
                        shape: typedIndex);

                    StaticHandle staticHandle = simulation.Statics.Add(
                        staticDescription);

                    collidableReference = collidableReferenceFactory.Create(
                        staticHandle);
                }
                else
                {
                    BodyDescription bodyDescription = bodyDescriptionFactory.Create(
                        bodyActivityDescription: bodyActivityDescriptionFactory.Create(
                            sleepThreshold),
                        bodyInertia: bodyInertiaFactory.Create(
                            mass: mass,
                            shape: shape),
                        bodyVelocity: bodyVelocityFactory.Create(
                            angularVelocity: angularVelocity,
                            linearVelocity: linearVelocity),
                        collidableDescription: collidableDescription,
                        collidableMobility: collidableMobility,
                        rigidPose: rigidPoseFactory.Create(
                            position: position),
                        shape: shape);

                    BodyHandle bodyHandle = simulation.Bodies.Add(
                        bodyDescription);

                    collidableReference = collidableReferenceFactory.Create(
                        collidableMobility: collidableMobility,
                        bodyHandle: bodyHandle);
                }

                recorder = new CollidableShapeComponent(
                    collidableReference: collidableReference,
                    shape: shape,
                    simulation: simulation);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return recorder;
        }
    }
}