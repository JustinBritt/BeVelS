namespace BeVelS.Graphics.GraphicsPipelines.Factories.Descriptions
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories.Descriptions;

    internal sealed class GraphicsPipelineDescriptionFactory : IGraphicsPipelineDescriptionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public GraphicsPipelineDescriptionFactory()
        {
        }

        public GraphicsPipelineDescription Create()
        {
            GraphicsPipelineDescription graphicsPipelineDescription = default;

            try
            {
                graphicsPipelineDescription = new GraphicsPipelineDescription();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return graphicsPipelineDescription;
        }

        public GraphicsPipelineDescription Create(
            BlendStateDescription blendState,
            DepthStencilStateDescription depthStencilStateDescription,
            RasterizerStateDescription rasterizerState,
            PrimitiveTopology primitiveTopology,
            ShaderSetDescription shaderSet,
            ResourceLayout[] resourceLayouts,
            OutputDescription outputs)
        {
            GraphicsPipelineDescription graphicsPipelineDescription = default;

            try
            {
                graphicsPipelineDescription = new GraphicsPipelineDescription(
                    blendState,
                    depthStencilStateDescription,
                    rasterizerState,
                    primitiveTopology,
                    shaderSet,
                    resourceLayouts,
                    outputs);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return graphicsPipelineDescription;
        }

        public GraphicsPipelineDescription Create(
            BlendStateDescription blendState,
            DepthStencilStateDescription depthStencilStateDescription,
            RasterizerStateDescription rasterizerState,
            PrimitiveTopology primitiveTopology,
            ShaderSetDescription shaderSet,
            ResourceLayout resourceLayout,
            OutputDescription outputs)
        {
            GraphicsPipelineDescription graphicsPipelineDescription = default;

            try
            {
                graphicsPipelineDescription = new GraphicsPipelineDescription(
                    blendState,
                    depthStencilStateDescription,
                    rasterizerState,
                    primitiveTopology,
                    shaderSet,
                    resourceLayout,
                    outputs);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return graphicsPipelineDescription;
        }

        public GraphicsPipelineDescription Create(
            BlendStateDescription blendState,
            DepthStencilStateDescription depthStencilStateDescription,
            RasterizerStateDescription rasterizerState,
            PrimitiveTopology primitiveTopology,
            ShaderSetDescription shaderSet,
            ResourceLayout[] resourceLayouts,
            OutputDescription outputs,
            ResourceBindingModel resourceBindingModel)
        {
            GraphicsPipelineDescription graphicsPipelineDescription = default;

            try
            {
                graphicsPipelineDescription = new GraphicsPipelineDescription(
                    blendState,
                    depthStencilStateDescription,
                    rasterizerState,
                    primitiveTopology,
                    shaderSet,
                    resourceLayouts,
                    outputs,
                    resourceBindingModel);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return graphicsPipelineDescription;
        }
    }
}