namespace BeVelS.Graphics.UIRenderers.Interfaces
{
    using System;

    using BepuUtilities;

    using Veldrid;

    using BeVelS.Graphics.Fonts.Interfaces;
    using BeVelS.Graphics.Glyphs.Structs;
    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.ResourceSets.InterfacesFactories;
    using BeVelS.Graphics.ResourceSets.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.ShaderSets.InterfacesFactories.Descriptions;

    public interface IGlyphRenderer : IDisposable
    {
        void PreparePipeline(
            IGraphicsPipelineDescriptionFactory graphicsPipelineDescriptionFactory,
            IShaderSetDescriptionFactory shaderSetDescriptionFactory,
            BlendStateDescription blendStateDescription,
            DepthStencilStateDescription depthStencilStateDescription,
            GraphicsDevice graphicsDevice,
            OutputDescription outputDescription,
            RasterizerStateDescription rasterizerStateDescription);

        void Render(
            IResourceSetDescriptionFactory resourceSetDescriptionFactory,
            IResourceSetFactory resourceSetFactory,
            CommandList commandList,
            IFont font,
            Span<GlyphInstance> glyphs,
            GraphicsDevice graphicsDevice,
            Int2 screenResolution);
    }
}