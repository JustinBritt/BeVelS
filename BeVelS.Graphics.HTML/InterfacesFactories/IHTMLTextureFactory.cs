namespace BeVelS.Graphics.HTML.InterfacesFactories
{
    using UltralightNet;

    using BeVelS.Graphics.HTML.Interfaces;

    public interface IHTMLTextureFactory
    {
        IHTMLTexture Create(
            ULBitmap[] ULBitmaps);
    }
}