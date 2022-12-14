namespace BeVelS.Graphics.ShapeRenderers.InterfacesFactories
{
    using Veldrid;

    using BeVelS.Graphics.BufferConstants.InterfacesFactories.VertexConstants;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Buffers.InterfacesFactories.ShapeInstances;
    using BeVelS.Graphics.Buffers.InterfacesFactories.VertexConstants;
    using BeVelS.Graphics.Buffers.InterfacesFactories;
    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories;
    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.FragmentResourceLayouts;
    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.VertexResourceLayouts;
    using BeVelS.Graphics.Shaders.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories.FragmentShaders;
    using BeVelS.Graphics.Shaders.InterfacesFactories.VertexShaders;
    using BeVelS.Graphics.Shaders.InterfacesFactories;
    using BeVelS.Graphics.ShapeRenderers.Interfaces;

    public interface IBoxRendererFactory
    {
        IBoxRenderer Create(
            IBoxVertexConstantsFactory boxVertexConstantsFactory,
            IBoxInstancesBufferFactory boxInstancesBufferFactory,
            IBoxVertexConstantsBufferFactory boxVertexConstantsBufferFactory,
            IBufferDescriptionFactory bufferDescriptionFactory,
            IIndexBufferFactory indexBufferFactory,
            IBoxGraphicsPipelineFactory boxGraphicsPipelineFactory,
            IBoxFragmentResourceLayoutFactory boxFragmentResourceLayoutFactory,
            IBoxVertexResourceLayoutFactory boxVertexResourceLayoutFactory,
            IResourceLayoutDescriptionFactory resourceLayoutDescriptionFactory,
            IResourceLayoutElementDescriptionFactory resourceLayoutElementDescriptionFactory,
            IBoxFragmentShaderFactory boxFragmentShaderFactory,
            IBoxShaderFactory boxShaderFactory,
            IBoxVertexShaderFactory boxVertexShaderFactory,
            IShaderDescriptionFactory shaderDescriptionFactory,
            GraphicsDevice graphicsDevice,
            int maximumInstancesPerDraw = 2048);
    }
}