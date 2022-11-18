namespace BeVelS.ECS.Messages.Renderers.Structs
{
    using System.Numerics;

    public struct UILineDrawMessage
    {
        public UILineDrawMessage(
            Vector3 color,
            Vector2 end,
            float radius,
            Vector2 start)
        {
            this.Color = color;

            this.End = end;

            this.Radius = radius;

            this.Start = start;
        }

        public Vector3 Color { get; }

        public Vector2 End { get; }

        public float Radius { get; }

        public Vector2 Start { get; }
    }
}