namespace BeVelS.Graphics.Debugging.Classes
{
    using Veldrid;

    using BeVelS.Graphics.Debugging.Interfaces;

    internal sealed class RenderDocDebugger : IRenderDocDebugger
    {
        private RenderDoc RenderDoc;

        public RenderDocDebugger()
        {
            RenderDoc.Load(
                out RenderDoc);
        }

        public RenderDoc GetRenderDoc()
        {
            return this.RenderDoc;
        }
    }
}