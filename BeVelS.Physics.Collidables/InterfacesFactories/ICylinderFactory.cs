namespace BeVelS.Physics.Collidables.InterfacesFactories
{
    using BepuPhysics.Collidables;

    public interface ICylinderFactory
    {
        Cylinder Create(
            float radius,
            float length);
    }
}