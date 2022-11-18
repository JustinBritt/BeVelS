namespace BeVelS.Graphics.Vertices.InterfacesAbstractFactories
{
    using BeVelS.Graphics.Vertices.InterfacesFactories;

    public interface IVerticesAbstractFactory
    {
        IPositionColorVertexFactory CreatePositionColorVertexFactory();

        IPositionUVVertexFactory CreatePositionUVVertexFactory();
    }
}