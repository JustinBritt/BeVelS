namespace BeVelS.Graphics.UIRenderers.Interfaces
{
    using System;

    using BepuUtilities;

    using Veldrid;

    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Instances;
    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.ShaderSets.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.UILines.Structs;

    public interface IUILineRenderer : IDisposable
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
            IBufferDescriptionFactory bufferDescriptionFactory,
            IUILineInstancesBufferFactory UILineInstancesBufferFactory,
            CommandList commandList,
            int count,
            GraphicsDevice graphicsDevice,
            UILineInstance[] lines,
            Int2 screenResolution);
    }
}