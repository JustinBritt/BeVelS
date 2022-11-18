namespace BeVelS.ECS.Components.Shapes.Structs
{
    using BeVelS.Graphics.Shapes.Structs;

    public struct CylinderInstanceComponent
    {
        public CylinderInstanceComponent(
            CylinderInstance value)
        {
            this.Value = value;
        }

        public CylinderInstance Value { get; set; }
    }
}