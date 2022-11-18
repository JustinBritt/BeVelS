namespace BeVelS.Physics.Collidables.InterfacesFactories
{
    using BepuPhysics.Collidables;

    using BeVelS.Physics.Collidables.InterfacesFactories;

    public interface ICapsuleFactory
    {
        Capsule Create(
            float radius,
            float length);
    }
}