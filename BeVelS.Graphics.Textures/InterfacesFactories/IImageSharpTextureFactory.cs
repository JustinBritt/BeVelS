namespace BeVelS.Graphics.Textures.InterfacesFactories
{
    using Veldrid;
    using Veldrid.ImageSharp;

    public interface IImageSharpTextureFactory
    {
        ImageSharpTexture Create(
            GraphicsDevice graphicsDevice,
            string imagePath,
            bool mipmap,
            bool srgb);
    }
}