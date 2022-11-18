namespace BeVelS.Graphics.UIRenderers.InterfacesFactories
{
    using Veldrid;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.BufferConstants.InterfacesFactories.VertexConstants;
    using BeVelS.Graphics.Buffers.InterfacesFactories;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Instances;
    using BeVelS.Graphics.Buffers.InterfacesFactories.VertexConstants;
    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories;
    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.ResourceLayouts;
    using BeVelS.Graphics.Samplers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories;
    using BeVelS.Graphics.Shaders.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories.FragmentShaders;
    using BeVelS.Graphics.Shaders.InterfacesFactories.VertexShaders;
    using BeVelS.Graphics.UIRenderers.Interfaces;

    public interface IImageRendererFactory
    {
        IImageRenderer Create(
            IVector2Factory vector2Factory,
            IImageVertexConstantsFactory imageVertexConstantsFactory,
            IBufferDescriptionFactory bufferDescriptionFactory,
            IImageInstancesBufferFactory imageInstancesBufferFactory,
            IImageVertexConstantsBufferFactory imageVertexConstantsBufferFactory,
            IIndexBufferFactory indexBufferFactory,
            IImageGraphicsPipelineFactory imageGraphicsPipelineFactory,
            IImageResourceLayoutFactory imageResourceLayoutFactory,
            IResourceLayoutDescriptionFactory resourceLayoutDescriptionFactory,
            IResourceLayoutElementDescriptionFactory resourceLayoutElementDescriptionFactory,
            ISamplerDescriptionFactory samplerDescriptionFactory,
            IImageFragmentShaderFactory imageFragmentShaderFactory,
            IImageShaderFactory imageShaderFactory,
            IImageVertexShaderFactory imageVertexShaderFactory,
            IShaderDescriptionFactory shaderDescriptionFactory,
            GraphicsDevice graphicsDevice,
            int maximumPerDraw = 2048);
    }
}