namespace BeVelS.Graphics.Vertices.Structs
{
    using System.Numerics;

    using Veldrid;

    public struct PositionColorVertex
    {
        public const uint SizeInBytes = 3 * sizeof(float) + 4 * sizeof(float);

        public PositionColorVertex(
            Vector3 position,
            RgbaFloat color)
        {
            this.Position = position;

            this.Color = color;
        }

        public Vector3 Position { get; }

        public RgbaFloat Color { get; }
    }
}