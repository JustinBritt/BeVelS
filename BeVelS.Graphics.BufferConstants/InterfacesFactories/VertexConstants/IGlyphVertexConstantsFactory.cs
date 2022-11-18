namespace BeVelS.Graphics.BufferConstants.InterfacesFactories.VertexConstants
{
    using System.Numerics;

    using BeVelS.Graphics.BufferConstants.Structs.VertexConstants;

    public interface IGlyphVertexConstantsFactory
    {
        GlyphVertexConstants Create(
            Vector2 inverseAtlasResolution,
            Vector2 packedToScreenScale,
            Vector2 screenToNDCScale);
    }
}