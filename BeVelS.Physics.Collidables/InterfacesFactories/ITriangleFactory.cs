namespace BeVelS.Physics.Collidables.InterfacesFactories
{
    using System.Numerics;

    using BepuPhysics.Collidables;

    public interface ITriangleFactory
    {
        Triangle Create(
            Vector3 a,
            Vector3 b,
            Vector3 c);
    }
}