namespace BeVelS.Graphics.Viewports.InterfacesFactories
{
    using Veldrid;

    public interface IViewportFactory
    {
        Viewport Create(
            float height,
            float maxDepth,
            float minDepth,
            float width,
            float X,
            float Y);
    }
}