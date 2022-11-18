namespace BeVelS.Graphics.GraphicsPipelines.InterfacesFactories.Descriptions
{
    using Veldrid;

    public interface IGraphicsPipelineDescriptionFactory
    {
        GraphicsPipelineDescription Create();

        GraphicsPipelineDescription Create(
            BlendStateDescription blendState,
            DepthStencilStateDescription depthStencilStateDescription,
            RasterizerStateDescription rasterizerState,
            PrimitiveTopology primitiveTopology,
            ShaderSetDescription shaderSet,
            ResourceLayout[] resourceLayouts,
            OutputDescription outputs);

        GraphicsPipelineDescription Create(
            BlendStateDescription blendState,
            DepthStencilStateDescription depthStencilStateDescription,
            RasterizerStateDescription rasterizerState,
            PrimitiveTopology primitiveTopology,
            ShaderSetDescription shaderSet,
            ResourceLayout resourceLayout,
            OutputDescription outputs);

        GraphicsPipelineDescription Create(
            BlendStateDescription blendState,
            DepthStencilStateDescription depthStencilStateDescription,
            RasterizerStateDescription rasterizerState,
            PrimitiveTopology primitiveTopology,
            ShaderSetDescription shaderSet,
            ResourceLayout[] resourceLayouts,
            OutputDescription outputs,
            ResourceBindingModel resourceBindingModel);
    }
}