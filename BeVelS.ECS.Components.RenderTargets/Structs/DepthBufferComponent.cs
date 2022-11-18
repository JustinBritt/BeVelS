namespace BeVelS.ECS.Components.RenderTargets.Structs
{
    using Veldrid;

    public struct DepthBufferComponent
    {
        public DepthBufferComponent(
            Texture value)
        {
            this.Value = value;
        }

        public Texture Value { get; set; }
    }
}