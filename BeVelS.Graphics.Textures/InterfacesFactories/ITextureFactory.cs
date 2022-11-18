namespace BeVelS.Graphics.Textures.InterfacesFactories
{
    using Veldrid;

    public interface ITextureFactory
    {
        Texture Create(
            uint arrayLayers,
            GraphicsDevice graphicsDevice,
            uint height,
            uint mipLevels,
            PixelFormat pixelFormat,
            TextureSampleCount textureSampleCount,
            TextureUsage textureUsage,
            uint width);
    }
}