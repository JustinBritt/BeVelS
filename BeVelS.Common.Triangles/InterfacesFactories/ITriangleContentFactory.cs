namespace BeVelS.Common.Triangles.InterfacesFactories
{
    using System.Numerics;

    using BeVelS.Common.Triangles.Structs;

    public interface ITriangleContentFactory
    {
        TriangleContent Create(
            Vector3 A,
            Vector3 B,
            Vector3 C);
    }
}