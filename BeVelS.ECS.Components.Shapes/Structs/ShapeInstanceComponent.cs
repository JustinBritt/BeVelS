namespace BeVelS.ECS.Components.Shapes.Structs
{
    using BeVelS.Graphics.Shapes.Interfaces;

    public struct ShapeInstanceComponent
    {
        public ShapeInstanceComponent(
            IShapeInstance value)
        {
            this.Value = value;
        }

        public IShapeInstance Value { get; set; }
    }
}