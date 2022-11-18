namespace BeVelS.Graphics.Fonts.InterfacesFactories
{
    using BeVelS.Graphics.Fonts.Interfaces;

    public interface IFontPackerFactory
    {
        IFontPacker Create(
            int width,
            int mipLevels,
            int padding,
            int characterCount);
    }
}