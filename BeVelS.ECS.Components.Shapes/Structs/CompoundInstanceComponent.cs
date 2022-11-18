namespace BeVelS.ECS.Components.Shapes.Structs
{
    using BeVelS.Graphics.Shapes.Structs;

    public struct CompoundInstanceComponent
    {
        public CompoundInstanceComponent(
            CompoundInstance value)
        {
            this.Value = value;
        }

        public CompoundInstance Value { get; set; }
    }
}