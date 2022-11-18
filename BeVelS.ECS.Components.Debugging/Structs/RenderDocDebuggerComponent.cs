namespace BeVelS.ECS.Components.Debugging.Structs
{
    using BeVelS.Graphics.Debugging.Interfaces;

    public struct RenderDocDebuggerComponent
    {
        public RenderDocDebuggerComponent(
            IRenderDocDebugger value)
        {
            this.Value = value;
        }

        public IRenderDocDebugger Value { get; set; }
    }
}