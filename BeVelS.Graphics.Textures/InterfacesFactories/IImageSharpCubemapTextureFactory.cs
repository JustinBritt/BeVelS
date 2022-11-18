namespace BeVelS.Graphics.Textures.InterfacesFactories
{
    using SixLabors.ImageSharp;
    using SixLabors.ImageSharp.PixelFormats;

    using Veldrid.ImageSharp;

    public interface IImageSharpCubemapTextureFactory
    {
        ImageSharpCubemapTexture Create(
            Image<Rgba32> negativeX,
            Image<Rgba32> negativeY,
            Image<Rgba32> negativeZ,
            Image<Rgba32> positiveX,
            Image<Rgba32> positiveY,
            Image<Rgba32> positiveZ,
            bool mipmap = true);

        ImageSharpCubemapTexture Create(
            Image<Rgba32> uniform,
            bool mipmap = true);
    }
}