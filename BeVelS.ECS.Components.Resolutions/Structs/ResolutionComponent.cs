namespace BeVelS.ECS.Components.Resolutions.Structs
{
    using BepuUtilities;

    public struct ResolutionComponent
    {
        public ResolutionComponent(
            Int2 value)
        {
            this.Value = value;
        }

        public Int2 Value { get; set; }
    }
}