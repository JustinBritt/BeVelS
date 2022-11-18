namespace BeVelS.ECS.Components.RenderTargets.Structs
{
    using Veldrid;

    public struct ResolvedColorBufferComponent
    {
        public ResolvedColorBufferComponent(
            Texture value)
        {
            this.Value = value;
        }

        public Texture Value { get; set; }
    }
}