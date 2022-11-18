namespace BeVelS.ECS.Components.RenderTargets.Structs
{
    using Veldrid;

    public struct ColorBufferComponent
    {
        public ColorBufferComponent(
            Texture value)
        {
            this.Value = value;
        }

        public Texture Value { get; set; }
    }
}