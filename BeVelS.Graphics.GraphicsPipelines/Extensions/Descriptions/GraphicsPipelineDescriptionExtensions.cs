namespace BeVelS.Graphics.GraphicsPipelines.Extensions.Descriptions
{
    using Veldrid;

    public static class GraphicsPipelineDescriptionExtensions
    {
        public static GraphicsPipelineDescription WithBlendState(
            this GraphicsPipelineDescription graphicsPipelineDescription,
            BlendStateDescription blendStateDescription)
        {
            graphicsPipelineDescription.BlendState = blendStateDescription;

            return graphicsPipelineDescription;
        }

        public static GraphicsPipelineDescription WithDepthStencilState(
            this GraphicsPipelineDescription graphicsPipelineDescription,
            DepthStencilStateDescription depthStencilStateDescription)
        {
            graphicsPipelineDescription.DepthStencilState = depthStencilStateDescription;

            return graphicsPipelineDescription;
        }

        public static GraphicsPipelineDescription WithOutputs(
            this GraphicsPipelineDescription graphicsPipelineDescription,
            OutputDescription outputDescription)
        {
            graphicsPipelineDescription.Outputs = outputDescription;

            return graphicsPipelineDescription;
        }

        public static GraphicsPipelineDescription WithPrimitiveTopology(
            this GraphicsPipelineDescription graphicsPipelineDescription,
            PrimitiveTopology primitiveTopology)
        {
            graphicsPipelineDescription.PrimitiveTopology = primitiveTopology;

            return graphicsPipelineDescription;
        }

        public static GraphicsPipelineDescription WithRasterizerState(
            this GraphicsPipelineDescription graphicsPipelineDescription,
            RasterizerStateDescription rasterizerStateDescription)
        {
            graphicsPipelineDescription.RasterizerState = rasterizerStateDescription;

            return graphicsPipelineDescription;
        }

        public static GraphicsPipelineDescription WithResourceBindingModel(
            this GraphicsPipelineDescription graphicsPipelineDescription,
            ResourceBindingModel resourceBindingModel)
        {
            graphicsPipelineDescription.ResourceBindingModel = resourceBindingModel;

            return graphicsPipelineDescription;
        }

        public static GraphicsPipelineDescription WithResourceLayouts(
            this GraphicsPipelineDescription graphicsPipelineDescription,
            ResourceLayout[] resourceLayouts)
        {
            graphicsPipelineDescription.ResourceLayouts = resourceLayouts;

            return graphicsPipelineDescription;
        }

        public static GraphicsPipelineDescription WithShaderSet(
            this GraphicsPipelineDescription graphicsPipelineDescription,
            ShaderSetDescription shaderSetDescription)
        {
            graphicsPipelineDescription.ShaderSet = shaderSetDescription;

            return graphicsPipelineDescription;
        }
    }
}