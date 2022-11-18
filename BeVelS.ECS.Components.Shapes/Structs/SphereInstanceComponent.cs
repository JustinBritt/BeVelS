namespace BeVelS.ECS.Components.Shapes.Structs
{
    using BeVelS.Graphics.Shapes.Structs;

    public struct SphereInstanceComponent
    {
        public SphereInstanceComponent(
            SphereInstance value)
        {
            this.Value = value;
        }

        public SphereInstance Value { get; set; }
    }
}