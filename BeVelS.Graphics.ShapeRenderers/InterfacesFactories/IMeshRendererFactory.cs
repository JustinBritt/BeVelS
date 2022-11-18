namespace BeVelS.Graphics.ShapeRenderers.InterfacesFactories
{
    using Veldrid;

    using BeVelS.Graphics.BufferConstants.InterfacesFactories.VertexConstants;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Buffers.InterfacesFactories.ShapeInstances;
    using BeVelS.Graphics.Buffers.InterfacesFactories.VertexConstants;
    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories;
    using BeVelS.Graphics.Meshes.Interfaces;
    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.FragmentResourceLayouts;
    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.VertexResourceLayouts;
    using BeVelS.Graphics.ResourceSets.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories.FragmentShaders;
    using BeVelS.Graphics.Shaders.InterfacesFactories.VertexShaders;
    using BeVelS.Graphics.Shaders.InterfacesFactories;
    using BeVelS.Graphics.ShapeRenderers.Interfaces;

    public interface IMeshRendererFactory
    {
        IMeshRenderer Create(
            IMeshVertexConstantsFactory meshVertexConstantsFactory,
            IBufferDescriptionFactory bufferDescriptionFactory,
            IMeshInstancesBufferFactory meshInstancesBufferFactory,
            IMeshVertexConstantsBufferFactory meshVertexConstantsBufferFactory,
            IMeshGraphicsPipelineFactory meshGraphicsPipelineFactory,
            IMeshFragmentResourceLayoutFactory meshFragmentResourceLayoutFactory,
            IMeshVertexResourceLayoutFactory meshVertexResourceLayoutFactory,
            IResourceLayoutDescriptionFactory resourceLayoutDescriptionFactory,
            IResourceLayoutElementDescriptionFactory resourceLayoutElementDescriptionFactory,
            IResourceSetDescriptionFactory resourceSetDescriptionFactory,
            IMeshFragmentShaderFactory meshFragmentShaderFactory,
            IMeshShaderFactory meshShaderFactory,
            IMeshVertexShaderFactory meshVertexShaderFactory,
            IShaderDescriptionFactory shaderDescriptionFactory,
            GraphicsDevice graphicsDevice,
            IMeshCache meshCache,
            int maximumInstancesPerDraw = 256);
    }
}