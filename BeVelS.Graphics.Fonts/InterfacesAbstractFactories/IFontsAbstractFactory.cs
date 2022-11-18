namespace BeVelS.Graphics.Fonts.InterfacesAbstractFactories
{
    using BeVelS.Graphics.Fonts.InterfacesFactories;
    using BeVelS.Graphics.Fonts.InterfacesFactories.Batches;

    public interface IFontsAbstractFactory
    {
        IFontContentFactory CreateFontContentFactory();

        IFontFactory CreateFontFactory();

        IFontPackerFactory CreateFontPackerFactory();

        IGlyphBatchFactory CreateGlyphBatchFactory();
    }
}