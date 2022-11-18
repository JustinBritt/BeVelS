namespace BeVelS.Graphics.BackgroundRenderers.Interfaces
{
    using System;

    using Veldrid;

    using BeVelS.Graphics.Cameras.Interfaces;
    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories;
    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.ShaderSets.InterfacesFactories.Descriptions;

    public interface IBackgroundRenderer : IDisposable
    {
        void PreparePipeline(
            IBackgroundGraphicsPipelineFactory backgroundGraphicsPipelineFactory,
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
            GraphicsDevice graphicsDevice);
    }
}