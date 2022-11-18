namespace BeVelS.Graphics.LineRenderers.InterfacesAbstractFactories
{
    using BeVelS.Graphics.LineRenderers.InterfacesFactories;

    public interface ILineRenderersAbstractFactory
    {
        ILineRendererFactory CreateLineRendererFactory();
    }
}