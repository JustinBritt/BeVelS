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
    using BeVelS.Graphics.ResourceSets.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories.FragmentShaders;
    using BeVelS.Graphics.Shaders.InterfacesFactories.VertexShaders;
    using BeVelS.Graphics.Shaders.InterfacesFactories;
    using BeVelS.Graphics.ShapeRenderers.Interfaces;

    public interface ITriangleRendererFactory
    {
        ITriangleRenderer Create(
            ITriangleVertexConstantsFactory triangleVertexConstantsFactory,
            IBufferDescriptionFactory bufferDescriptionFactory,
            IIndexBufferFactory indexBufferFactory,
            ITriangleInstancesBufferFactory triangleInstancesBufferFactory,
            ITriangleVertexConstantsBufferFactory triangleVertexConstantsBufferFactory,
            ITriangleGraphicsPipelineFactory triangleGraphicsPipelineFactory,
            IResourceLayoutDescriptionFactory resourceLayoutDescriptionFactory,
            IResourceLayoutElementDescriptionFactory resourceLayoutElementDescriptionFactory,
            ITriangleFragmentResourceLayoutFactory triangleFragmentResourceLayoutFactory,
            ITriangleVertexResourceLayoutFactory triangleVertexResourceLayoutFactory,
            IResourceSetDescriptionFactory resourceSetDescriptionFactory,
            IShaderDescriptionFactory shaderDescriptionFactory,
            ITriangleFragmentShaderFactory triangleFragmentShaderFactory,
            ITriangleShaderFactory triangleShaderFactory,
            ITriangleVertexShaderFactory triangleVertexShaderFactory,
            GraphicsDevice graphicsDevice,
            int maximumInstancesPerDraw = 2048);
    }
}