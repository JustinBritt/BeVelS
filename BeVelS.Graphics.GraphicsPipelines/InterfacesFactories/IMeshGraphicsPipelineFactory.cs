namespace BeVelS.Graphics.GraphicsPipelines.InterfacesFactories
{
    using Veldrid;

    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.ShaderSets.InterfacesFactories.Descriptions;

    public interface IMeshGraphicsPipelineFactory
    {
        Pipeline Create(
            IGraphicsPipelineDescriptionFactory graphicsPipelineDescriptionFactory,
            IShaderSetDescriptionFactory shaderSetDescriptionFactory,
            BlendStateDescription blendStateDescription,
            DepthStencilStateDescription depthStencilStateDescription,
            ResourceLayout fragmentResourceLayout,
            GraphicsDevice graphicsDevice,
            OutputDescription outputDescription,
            RasterizerStateDescription rasterizerStateDescription,
            Shader[] shaders,
            ResourceLayout vertexResourceLayout);
    }
}