namespace BeVelS.Graphics.UIRenderers.InterfacesFactories
{
    using BepuUtilities.Memory;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.Images.InterfacesFactories.Batches;
    using BeVelS.Graphics.UIRenderers.Interfaces;

    public interface IImageBatchRendererFactory
    {
        IImageBatchRenderer Create(
            IVector2Factory vector2Factory,
            IImageBatchFactory imageBatchFactory,
            BufferPool bufferPool);
    }
}