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

    public interface IGlyphRendererFactory
    {
        IGlyphRenderer Create(
            IVector2Factory vector2Factory,
            IGlyphVertexConstantsFactory glyphVertexConstantsFactory,
            IBufferDescriptionFactory bufferDescriptionFactory,
            IGlyphInstancesBufferFactory glyphInstancesBufferFactory,
            IGlyphVertexConstantsBufferFactory glyphVertexConstantsBufferFactory,
            IIndexBufferFactory indexBufferFactory,
            IGlyphGraphicsPipelineFactory glyphGraphicsPipelineFactory,
            IGlyphResourceLayoutFactory glyphResourceLayoutFactory,
            IResourceLayoutDescriptionFactory resourceLayoutDescriptionFactory,
            IResourceLayoutElementDescriptionFactory resourceLayoutElementDescriptionFactory,
            ISamplerDescriptionFactory samplerDescriptionFactory,
            IGlyphFragmentShaderFactory glyphFragmentShaderFactory,
            IGlyphShaderFactory glyphShaderFactory,
            IGlyphVertexShaderFactory glyphVertexShaderFactory,
            IShaderDescriptionFactory shaderDescriptionFactory,
            GraphicsDevice graphicsDevice,
            int maximumGlyphsPerDraw = 2048);
    }
}