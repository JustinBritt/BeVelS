namespace BeVelS.Common.Meshes.Interfaces
{
    using BeVelS.Common.Triangles.Structs;

    public interface IMeshContent
    {
        ref TriangleContent[] GetTrianglesRef();
    }
}