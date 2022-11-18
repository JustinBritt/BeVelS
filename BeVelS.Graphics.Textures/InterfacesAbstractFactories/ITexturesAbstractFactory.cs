namespace BeVelS.Graphics.Textures.InterfacesAbstractFactories
{
    using BeVelS.Graphics.Textures.InterfacesFactories;

    public interface ITexturesAbstractFactory
    {
        ICubemapTextureFactory CreateCubemapTextureFactory();

        IImageSharpCubemapTextureFactory CreateImageSharpCubemapTextureFactory();

        IImageSharpTextureFactory CreateImageSharpTextureFactory();

        ITextureContentFactory CreateTextureContentFactory();

        ITextureFactory CreateTextureFactory();
    }
}