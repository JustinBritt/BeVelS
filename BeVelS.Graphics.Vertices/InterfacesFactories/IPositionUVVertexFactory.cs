namespace BeVelS.Graphics.Vertices.InterfacesFactories
{
    using System.Numerics;

    using BeVelS.Graphics.Vertices.Structs;

    public interface IPositionUVVertexFactory
    {
        PositionUVVertex Create(
            Vector3 position,
            Vector2 UV);
    }
}