namespace BeVelS.ECS.Components.Shapes.Structs
{
    using BeVelS.Graphics.Shapes.Structs;

    public struct MeshInstanceComponent
    {
        public MeshInstanceComponent(
            MeshInstance value)
        {
            this.Value = value;
        }

        public MeshInstance Value { get; set; }
    }
}