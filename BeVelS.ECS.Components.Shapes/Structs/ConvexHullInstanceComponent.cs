namespace BeVelS.ECS.Components.Shapes.Structs
{
    using BeVelS.Graphics.Shapes.Structs;

    public struct ConvexHullInstanceComponent
    {
        public ConvexHullInstanceComponent(
            ConvexHullInstance value)
        {
            this.Value = value;
        }

        public ConvexHullInstance Value { get; set; }
    }
}