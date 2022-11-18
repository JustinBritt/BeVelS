namespace BeVelS.Graphics.Vertices.Structs
{
    using System.Numerics;

    public struct PositionUVVertex
    {
        public const uint SizeInBytes = 3 * sizeof(float) + 2 * sizeof(float);

        public PositionUVVertex(
            Vector3 position,
            Vector2 UV)
        {
            this.Position = position;

            this.UV = UV;
        }

        public Vector3 Position { get; }

        public Vector2 UV { get; }
    }
}