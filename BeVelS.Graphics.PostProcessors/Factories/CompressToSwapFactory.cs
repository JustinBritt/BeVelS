namespace BeVelS.Graphics.PostProcessors.Factories
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.DepthStencilStates.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.PostProcessors.Classes;
    using BeVelS.Graphics.PostProcessors.Interfaces;
    using BeVelS.Graphics.PostProcessors.InterfacesFactories;
    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.ShaderSets.InterfacesFactories.Descriptions;

    internal sealed class CompressToSwapFactory : ICompressToSwapFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        public CompressToSwapFactory()
        {
        }

        public ICompressToSwap Create(
            IDepthStencilStateDescriptionFactory depthStencilStateDescriptionFactory,
            IGraphicsPipelineDescriptionFactory graphicsPipelineDescriptionFactory,
            IResourceLayoutDescriptionFactory resourceLayoutDescriptionFactory,
            IResourceLayoutElementDescriptionFactory resourceLayoutElementDescriptionFactory,
            IShaderDescriptionFactory shaderDescriptionFactory,
            IShaderSetDescriptionFactory shaderSetDescriptionFactory,
            BlendStateDescription blendStateDescription,
            GraphicsDevice graphicsDevice,
            OutputDescription outputDescription,
            RasterizerStateDescription rasterizerStateDescription)
        {
            ICompressToSwap compressToSwap = null;

            try
            {
                compressToSwap = new CompressToSwap(
                    depthStencilStateDescriptionFactory,
                    graphicsPipelineDescriptionFactory,
                    resourceLayoutDescriptionFactory,
                    resourceLayoutElementDescriptionFactory,
                    shaderDescriptionFactory,
                    shaderSetDescriptionFactory,
                    blendStateDescription,
                    graphicsDevice,
                    outputDescription,
                    rasterizerStateDescription);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return compressToSwap;
        }
    }
}