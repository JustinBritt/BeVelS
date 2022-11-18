namespace BeVelS.Graphics.Glyphs.InterfacesAbstractFactories
{
    using BeVelS.Graphics.Glyphs.InterfacesFactories;

    public interface IGlyphsAbstractFactory
    {
        IGlyphInstanceFactory CreateGlyphInstanceFactory();
    }
}