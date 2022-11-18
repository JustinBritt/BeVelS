namespace BeVelS.ECS.Components.Framebuffers.Structs
{
    using Veldrid;

    public struct ResolvedFramebufferComponent
    {
        public ResolvedFramebufferComponent(
            Framebuffer value)
        {
            this.Value = value;
        }

        public Framebuffer Value { get; set; }
    }
}