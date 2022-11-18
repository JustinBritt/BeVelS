namespace BeVelS.Common.Meshes.InterfacesFactories
{
    using BeVelS.Common.Meshes.Interfaces;
    using BeVelS.Common.Triangles.Structs;

    public interface IMeshContentFactory
    {
        IMeshContent Create(
            TriangleContent[] triangles);
    }
}