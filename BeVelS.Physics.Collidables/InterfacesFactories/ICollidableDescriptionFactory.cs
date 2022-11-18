namespace BeVelS.Physics.Collidables.InterfacesFactories
{
    using BepuPhysics.Collidables;

    public interface ICollidableDescriptionFactory
    {
        CollidableDescription Create(
            ContinuousDetection continuousDetection,
            TypedIndex shape,
            float maximumSpeculativeMargin,
            float minimumSpeculativeMargin);
    }
}