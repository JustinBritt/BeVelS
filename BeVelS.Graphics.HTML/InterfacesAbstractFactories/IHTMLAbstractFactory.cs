namespace BeVelS.Graphics.HTML.InterfacesAbstractFactories
{
    using BeVelS.Graphics.HTML.InterfacesFactories;
    using BeVelS.Graphics.HTML.InterfacesFactories.Batches;

    public interface IHTMLAbstractFactory
    {
        IHTMLBatchFactory CreateHTMLBatchFactory();

        IHTMLInstanceFactory CreateHTMLInstanceFactory();

        IHTMLTextureFactory CreateHTMLTextureFactory();

        IRenderableHTMLFactory CreateRenderableHTMLFactory();

        IRenderableHTMLsFactory CreateRenderableHTMLsFactory();

        IULBitmapRendererFactory CreateULBitmapRendererFactory();

        IULConfigFactory CreateULConfigFactory();

        IULViewConfigFactory CreateULViewConfigFactory();
    }
}