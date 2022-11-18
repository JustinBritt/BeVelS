namespace BeVelS.Graphics.Fonts.Interfaces.Batches
{
    using System;
    using System.Numerics;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.Fonts.Interfaces;
    using BeVelS.Graphics.Glyphs.Structs;

    public interface IGlyphBatch
    {
        int GlyphCount { get; }

        GlyphInstance[] Glyphs { get; }

        void Add(
            IVector2Factory vector2Factory,
            ReadOnlySpan<char> characters,
            int start,
            int count,
            Vector2 screenToPackedScale,
            Vector2 startingPosition,
            Vector2 horizontalAxis,
            Vector4 color,
            float height,
            IFont font);

        void Clear();
    }
}