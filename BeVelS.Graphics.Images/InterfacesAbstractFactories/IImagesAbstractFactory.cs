namespace BeVelS.Graphics.Images.InterfacesAbstractFactories
{
    using BeVelS.Graphics.Images.InterfacesFactories;
    using BeVelS.Graphics.Images.InterfacesFactories.Batches;

    public interface IImagesAbstractFactory
    {
        IImageBatchFactory CreateImageBatchFactory();

        IImageFactory CreateImageFactory();

        IImageInstanceFactory CreateImageInstanceFactory();

        IRenderableImageFactory CreateRenderableImageFactory();

        IRenderableImagesFactory CreateRenderableImagesFactory();
    }
}