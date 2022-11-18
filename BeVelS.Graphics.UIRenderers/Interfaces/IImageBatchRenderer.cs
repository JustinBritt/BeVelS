namespace BeVelS.Graphics.UIRenderers.Interfaces
{
    using System.Numerics;

    using BepuUtilities;

    using Veldrid;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Images.Interfaces;
    using BeVelS.Graphics.Images.InterfacesFactories;
    using BeVelS.Graphics.ResourceSets.InterfacesFactories;
    using BeVelS.Graphics.ResourceSets.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.ShaderSets.InterfacesFactories.Descriptions;

    public interface IImageBatchRenderer
    {
        Int2 Resolution { set; }

        void Draw(
            IImageInstanceFactory imageInstanceFactory,
            IRenderableImage image,
            in Vector2 targetPosition,
            in Vector2 size,
            in Vector2 horizontalAxis,
            in Vector4 color);

        void Draw(
            IVector2Factory vector2Factory,
            IImageInstanceFactory imageInstanceFactory,
            IRenderableImage image,
            in Vector2 targetPosition,
            in Vector2 size,
            in Vector4 color);

        void Draw(
            IVector2Factory vector2Factory,
            IImageInstanceFactory imageInstanceFactory,
            IRenderableImage image,
            in Vector2 targetPosition,
            in Vector2 size);

        void Draw(
            IVector2Factory vector2Factory,
            IImageInstanceFactory imageInstanceFactory,
            IRenderableImage image,
            in Vector2 targetPosition,
            float height);

        void Draw(
            IVector2Factory vector2Factory,
            IImageInstanceFactory imageInstanceFactory,
            IRenderableImage image,
            in Vector2 targetPosition,
            float height,
            in Vector4 color);

        unsafe void Flush(
            IGraphicsPipelineDescriptionFactory graphicsPipelineDescriptionFactory,
            IResourceSetDescriptionFactory resourceSetDescriptionFactory,
            IResourceSetFactory resourceSetFactory,
            IShaderSetDescriptionFactory shaderSetDescriptionFactory,
            CommandList commandList,
            GraphicsDevice graphicsDevice,
            IImageRenderer renderer,
            Int2 screenResolution);
    }
}