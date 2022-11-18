namespace BeVelS.Graphics.Textures.InterfacesFactories
{
    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.Textures.Interfaces;

    public interface ITextureContentFactory
    {
        ITextureContent Create(
            IVector2Factory vector2Factory,
            int width,
            int height,
            int mipLevels,
            int texelSizeInBytes);
    }
}