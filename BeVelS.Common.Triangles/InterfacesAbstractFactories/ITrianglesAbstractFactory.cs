namespace BeVelS.Common.Triangles.InterfacesAbstractFactories
{
    using BeVelS.Common.Triangles.InterfacesFactories;

    public interface ITrianglesAbstractFactory
    {
        ITriangleContentFactory CreateTriangleContentFactory();
    }
}