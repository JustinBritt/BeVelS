namespace BeVelS.ECS.Components.Shapes.Structs
{
    using BeVelS.Graphics.Shapes.Structs;

    public struct CapsuleInstanceComponent
    {
        public CapsuleInstanceComponent(
            CapsuleInstance value)
        {
            this.Value = value;
        }

        public CapsuleInstance Value { get; set; }
    }
}