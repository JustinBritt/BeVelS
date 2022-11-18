namespace BeVelS.ECS.Components.Shapes.Structs
{
    using BeVelS.Graphics.Shapes.Structs;

    public struct TriangleInstanceComponent
    {
        public TriangleInstanceComponent(
            TriangleInstance value)
        {
            this.Value = value;
        }

        public TriangleInstance Value { get; set; }
    }
}