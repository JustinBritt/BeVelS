namespace BeVelS.ECS.Components.Shapes.Structs
{
    using System;

    public struct TShapeInstanceComponent
    {
        public TShapeInstanceComponent(
            Type value)
        {
            this.Value = value;
        }

        public Type Value { get; }
    }
}