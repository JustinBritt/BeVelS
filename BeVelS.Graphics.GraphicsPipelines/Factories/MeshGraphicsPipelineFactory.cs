namespace BeVelS.Graphics.GraphicsPipelines.Factories
{
    using System;
    using System.Linq;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories;
    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.ShaderSets.InterfacesFactories.Descriptions;

    internal sealed class MeshGraphicsPipelineFactory : IMeshGraphicsPipelineFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MeshGraphicsPipelineFactory()
        {
        }

        public Pipeline Create(
            IGraphicsPipelineDescriptionFactory graphicsPipelineDescriptionFactory,
            IShaderSetDescriptionFactory shaderSetDescriptionFactory,
            BlendStateDescription blendStateDescription,
            DepthStencilStateDescription depthStencilStateDescription,
            ResourceLayout fragmentResourceLayout,
            GraphicsDevice graphicsDevice,
            OutputDescription outputDescription,
            RasterizerStateDescription rasterizerStateDescription,
            Shader[] shaders,
            ResourceLayout vertexResourceLayout)
        {
            Pipeline pipeline = null;

            try
            {
                GraphicsPipelineDescription graphicsPipelineDescription = graphicsPipelineDescriptionFactory.Create();

                graphicsPipelineDescription.BlendState = blendStateDescription;

                graphicsPipelineDescription.DepthStencilState = depthStencilStateDescription;

                graphicsPipelineDescription.RasterizerState = rasterizerStateDescription;

                graphicsPipelineDescription.PrimitiveTopology = PrimitiveTopology.TriangleList;

                graphicsPipelineDescription.ResourceLayouts = Array.Empty<ResourceLayout>().Prepend(fragmentResourceLayout).Prepend(vertexResourceLayout).ToArray();

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