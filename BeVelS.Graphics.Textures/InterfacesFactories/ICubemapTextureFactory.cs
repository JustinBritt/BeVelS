namespace BeVelS.Graphics.Textures.InterfacesFactories
{
    using SixLabors.ImageSharp;
    using SixLabors.ImageSharp.PixelFormats;

    using Veldrid;

    public interface ICubemapTextureFactory
    {
        Texture Create(
            IImageSharpCubemapTextureFactory ImageSharpCubemapTextureFactory,
            GraphicsDevice graphicsDevice,
            Image<Rgba32> uniform,
            bool mipmap = true);
    }
}