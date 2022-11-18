namespace BeVelS.Graphics.Glyphs.InterfacesFactories
{
    using System.Numerics;

    using BeVelS.Graphics.Glyphs.Structs;

    public interface IGlyphInstanceFactory
    {
        GlyphInstance Create(
            ref Vector2 start,
            ref Vector2 horizontalAxis,
            float scale,
            int sourceId,
            ref Vector4 color,
            ref Vector2 screenToPackedScale);
    }
}