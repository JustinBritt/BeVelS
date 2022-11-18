namespace BeVelS.ECS.Components.Shapes.Structs
{
    using BeVelS.Graphics.Shapes.Structs;

    public struct BigCompoundInstanceComponent
    {
        public BigCompoundInstanceComponent(
            BigCompoundInstance value)
        {
            this.Value = value;
        }

        public BigCompoundInstance Value { get; set; }
    }
}