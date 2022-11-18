namespace BeVelS.Graphics.LineRenderers.Interfaces
{
    using System;

    using BepuUtilities;

    using Veldrid;

    using BeVelS.Graphics.Cameras.Interfaces;
    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.ShaderSets.InterfacesFactories.Descriptions;

    using BeVelS.Physics.Constraints.Structs.Lines;

    public interface ILineRenderer : IDisposable
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
            ICamera camera,
            CommandList commandList,
            int count,
            GraphicsDevice graphicsDevice,
            Span<LineInstance> instances,
            Int2 resolution);
    }
}