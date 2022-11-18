namespace BeVelS.ECS.Components.Fonts.Structs
{
    using BeVelS.Graphics.Fonts.Interfaces;

    public struct FontComponent
    {
        public FontComponent(
            IFont value)
        {
            this.Value = value;
        }

        public IFont Value { get; set; }
    }
}