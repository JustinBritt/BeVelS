namespace BeVelS.Graphics.Shapes.InterfacesFactories
{
    using System.Numerics;

    using BeVelS.Graphics.Shapes.Structs;

    public interface IMeshInstanceFactory
    {
        MeshInstance Create(
            Quaternion orientation,
            Vector3 position,
            Vector3 scale,
            int vertexCount,
            int vertexStart);
    }
}