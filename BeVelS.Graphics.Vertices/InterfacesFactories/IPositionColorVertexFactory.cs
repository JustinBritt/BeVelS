namespace BeVelS.Graphics.Vertices.InterfacesFactories
{
    using System.Numerics;

    using Veldrid;

    using BeVelS.Graphics.Vertices.Structs;

    public interface IPositionColorVertexFactory
    {
        PositionColorVertex Create(
            Vector3 position,
            RgbaFloat color);
    }
}