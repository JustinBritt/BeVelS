namespace BeVelS.Graphics.UIRenderers.InterfacesAbstractFactories
{
    using BeVelS.Graphics.UIRenderers.InterfacesFactories;

    public interface IUIRenderersAbstractFactory
    {
        IGlyphBatchRendererFactory CreateGlyphBatchRendererFactory();

        IGlyphRendererFactory CreateGlyphRendererFactory();

        IHTMLBatchRendererFactory CreateHTMLBatchRendererFactory();

        IHTMLRendererFactory CreateHTMLRendererFactory();

        IImageBatchRendererFactory CreateImageBatchRendererFactory();

        IImageRendererFactory CreateImageRendererFactory();

        IUILineBatchRendererFactory CreateUILineBatchRendererFactory();

        IUILineRendererFactory CreateUILineRendererFactory();
    }
}