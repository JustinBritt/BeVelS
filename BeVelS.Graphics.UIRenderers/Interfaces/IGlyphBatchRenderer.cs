namespace BeVelS.Graphics.UIRenderers.Interfaces
{
    using System.Numerics;

    using BepuUtilities;

    using Veldrid;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.Fonts.Interfaces;
    using BeVelS.Graphics.ResourceSets.InterfacesFactories;
    using BeVelS.Graphics.ResourceSets.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Text.Interfaces;

    public interface IGlyphBatchRenderer
    {
        Int2 Resolution { set; }

        void Flush(
            IResourceSetDescriptionFactory resourceSetDescriptionFactory,
            IResourceSetFactory resourceSetFactory,
            CommandList commandList,
            GraphicsDevice graphicsDevice,
            IGlyphRenderer renderer,
            Int2 screenResolution);

        void Write(
            IVector2Factory vector2Factory,
            ITextBuilder characters,
            int start,
            int count,
            Vector2 targetPosition,
            float height,
            Vector2 horizontalAxis,
            Vector4 color,
            IFont font);

        void Write(
            IVector2Factory vector2Factory,
            ITextBuilder characters,
            Vector2 targetPosition,
            float height,
            Vector4 color,
            IFont font);

        void Write(
            IVector2Factory vector2Factory,
            IVector4Factory vector4Factory,
            ITextBuilder characters,
            Vector2 targetPosition,
            float height,
            Vector3 color,
            IFont font);

        void Write(
            IVector2Factory vector2Factory,
            ITextBuilder characters,
            Vector2 targetPosition,
            float height,
            Vector2 horizontalAxis,
            Vector4 color,
            IFont font);

        void Write(
            IVector2Factory vector2Factory,
            IVector4Factory vector4Factory,
            ITextBuilder characters,
            Vector2 targetPosition,
            float height,
            Vector2 horizontalAxis,
            Vector3 color,
            IFont font);
    }
}