namespace BeVelS.Graphics.PostProcessors.InterfacesFactories
{
    using Veldrid;

    using BeVelS.Graphics.DepthStencilStates.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.PostProcessors.Interfaces;
    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.ShaderSets.InterfacesFactories.Descriptions;

    public interface ICompressToSwapFactory
    {
        ICompressToSwap Create(
            IDepthStencilStateDescriptionFactory depthStencilStateDescriptionFactory,
            IGraphicsPipelineDescriptionFactory graphicsPipelineDescriptionFactory,
            IResourceLayoutDescriptionFactory resourceLayoutDescriptionFactory,
            IResourceLayoutElementDescriptionFactory resourceLayoutElementDescriptionFactory,
            IShaderDescriptionFactory shaderDescriptionFactory,
            IShaderSetDescriptionFactory shaderSetDescriptionFactory,
            BlendStateDescription blendStateDescription,
            GraphicsDevice graphicsDevice,
            OutputDescription outputDescription,
            RasterizerStateDescription rasterizerStateDescription);
    }
}