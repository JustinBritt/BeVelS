namespace BeVelS.Graphics.GraphicsPipelines.Factories
{
    using System;
    using System.Linq;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories;
    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.ShaderSets.InterfacesFactories.Descriptions;

    internal sealed class UILineGraphicsPipelineFactory : IUILineGraphicsPipelineFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public UILineGraphicsPipelineFactory()
        {
        }

        public Pipeline Create(
            IGraphicsPipelineDescriptionFactory graphicsPipelineDescriptionFactory,
            IShaderSetDescriptionFactory shaderSetDescriptionFactory,
            BlendStateDescription blendStateDescription,
            DepthStencilStateDescription depthStencilStateDescription,
            GraphicsDevice graphicsDevice,
            OutputDescription outputDescription,
            RasterizerStateDescription rasterizerStateDescription,
            ResourceLayout resourceLayout,
            Shader[] shaders)
        {
            Pipeline pipeline = null;

            try
            {
                GraphicsPipelineDescription graphicsPipelineDescription = graphicsPipelineDescriptionFactory.Create();

                graphicsPipelineDescription.BlendState = blendStateDescription;

                graphicsPipelineDescription.DepthStencilState = depthStencilStateDescription;

                graphicsPipelineDescription.RasterizerState = rasterizerStateDescription;

                graphicsPipelineDescription.PrimitiveTopology = PrimitiveTopology.TriangleList;

                graphicsPipelineDescription.ResourceLayouts = Array.Empty<ResourceLayout>().Prepend(resourceLayout).ToArray();

                graphicsPipelineDescription.ShaderSet = shaderSetDescriptionFactory.Create(
                    vertexLayouts: Array.Empty<VertexLayoutDescription>(),
                    shaders: shaders);

                graphicsPipelineDescription.Outputs = outputDescription;

                pipeline = graphicsDevice.ResourceFactory.CreateGraphicsPipeline(
                    graphicsPipelineDescription);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return pipeline;
        }
    }
}