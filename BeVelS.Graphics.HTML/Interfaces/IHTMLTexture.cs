namespace BeVelS.Graphics.HTML.Interfaces
{
    using Veldrid;

    public interface IHTMLTexture
    {
        Texture CreateTexture(
            GraphicsDevice graphicsDevice);
    }
}