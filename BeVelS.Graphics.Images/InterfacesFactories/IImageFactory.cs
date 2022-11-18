namespace BeVelS.Graphics.Images.InterfacesFactories
{
    using SixLabors.ImageSharp;
    using SixLabors.ImageSharp.PixelFormats;

    public interface IImageFactory
    {
        Image<TPixel> Create<TPixel>(
            TPixel backgroundColor,
            int height,
            int width)
            where TPixel : unmanaged, IPixel<TPixel>;
    }
}