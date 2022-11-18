namespace BeVelS.Physics.Collidables.InterfacesFactories
{
    using BepuPhysics.Collidables;

    public interface IBoxFactory
    {
        Box Create(
            float width,
            float height,
            float length);
    }
}