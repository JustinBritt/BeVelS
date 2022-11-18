namespace BeVelS.Physics.Collidables.InterfacesFactories
{
    using System.Numerics;

    using BepuPhysics.Collidables;

    public interface IShapeFactory
    {
        IShape Create(
            IBoxFactory boxFactory,
            float width,
            float height,
            float length);

        IShape Create(
            ICapsuleFactory capsuleFactory,
            float radius,
            float length);

        IShape Create(
            ICylinderFactory cylinderFactory,
            float radius,
            float length);

        IShape Create(
            ISphereFactory sphereFactory,
            float radius);

        IShape Create(
            ITriangleFactory triangleFactory,
            Vector3 a,
            Vector3 b,
            Vector3 c);
    }
}