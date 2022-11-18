namespace BeVelS.Graphics.UIRenderers.InterfacesFactories
{
    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.Fonts.InterfacesFactories.Batches;
    using BeVelS.Graphics.UIRenderers.Interfaces;

    public interface IGlyphBatchRendererFactory
    {
        IGlyphBatchRenderer Create(
            IVector2Factory vector2Factory,
            IGlyphBatchFactory glyphBatchFactory);
    }
}