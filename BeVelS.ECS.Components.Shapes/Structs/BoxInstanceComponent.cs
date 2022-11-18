namespace BeVelS.ECS.Components.Shapes.Structs
{
    using BeVelS.Graphics.Shapes.Structs;

    public struct BoxInstanceComponent
    {
        public BoxInstanceComponent(
            BoxInstance value)
        {
            this.Value = value;
        }

        public BoxInstance Value { get; set; }
    }
}