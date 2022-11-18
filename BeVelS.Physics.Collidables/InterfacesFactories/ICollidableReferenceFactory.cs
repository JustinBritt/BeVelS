namespace BeVelS.Physics.Collidables.InterfacesFactories
{
    using BepuPhysics;
    using BepuPhysics.Collidables;

    public interface ICollidableReferenceFactory
    {
        CollidableReference Create(
            StaticHandle staticHandle);

        CollidableReference Create(
            CollidableMobility collidableMobility,
            BodyHandle bodyHandle);
    }
}