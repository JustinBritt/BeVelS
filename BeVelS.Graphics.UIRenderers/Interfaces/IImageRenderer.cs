namespace BeVelS.Graphics.UIRenderers.Interfaces
{
    using System;

    using BepuUtilities;

    using Veldrid;

    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Images.Interfaces;
    using BeVelS.Graphics.Images.Structs;
    using BeVelS.Graphics.ResourceSets.InterfacesFactories;
    using BeVelS.Graphics.ResourceSets.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.ShaderSets.InterfacesFactories.Descriptions;

    public interface IImageRenderer : IDisposable
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
            IGraphicsPipelineDescriptionFactory graphicsPipelineDescriptionFactory,
            IResourceSetDescriptionFactory resourceSetDescriptionFactory,
            IResourceSetFactory resourceSetFactory,
            IShaderSetDescriptionFactory shaderSetDescriptionFactory,
            CommandList commandList,
            GraphicsDevice graphicsDevice,
            IRenderableImage image,
            Span<ImageInstance> instances,
            Int2 screenResolution);
    }
}