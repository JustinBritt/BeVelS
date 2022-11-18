namespace BeVelS.Graphics.UIRenderers.InterfacesFactories
{
    using BepuUtilities.Memory;
    
    using BeVelS.Common.Vectors.InterfacesFactories;
    
    using BeVelS.Graphics.HTML.InterfacesFactories.Batches;
    using BeVelS.Graphics.UIRenderers.Interfaces;

    public interface IHTMLBatchRendererFactory
    {
        IHTMLBatchRenderer Create(
            IVector2Factory vector2Factory,
            IHTMLBatchFactory HTMLBatchFactory,
            BufferPool bufferPool);
    }
}