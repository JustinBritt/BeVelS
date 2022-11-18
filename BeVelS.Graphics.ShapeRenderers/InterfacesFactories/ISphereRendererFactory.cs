namespace BeVelS.Graphics.ShapeRenderers.InterfacesFactories
{
    using Veldrid;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.BufferConstants.InterfacesFactories.FragmentConstants;
    using BeVelS.Graphics.BufferConstants.InterfacesFactories.VertexConstants;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Buffers.InterfacesFactories.FragmentConstants;
    using BeVelS.Graphics.Buffers.InterfacesFactories.ShapeInstances;
    using BeVelS.Graphics.Buffers.InterfacesFactories.VertexConstants;
    using BeVelS.Graphics.Buffers.InterfacesFactories;
    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories;
    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.FragmentResourceLayouts;
    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.VertexResourceLayouts;
    using BeVelS.Graphics.ResourceSets.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.ResourceSets.InterfacesFactories;
    using BeVelS.Graphics.Shaders.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories.FragmentShaders;
    using BeVelS.Graphics.Shaders.InterfacesFactories.VertexShaders;
    using BeVelS.Graphics.Shaders.InterfacesFactories;
    using BeVelS.Graphics.ShapeRenderers.Interfaces;

    public interface ISphereRendererFactory
    {
        ISphereRenderer Create(
            IVector2Factory vector2Factory,
            ISphereFragmentConstantsFactory sphereFragmentConstantsFactory,
            ISphereVertexConstantsFactory sphereVertexConstantsFactory,
            IBufferDescriptionFactory bufferDescriptionFactory,
            IIndexBufferFactory indexBufferFactory,
            ISphereFragmentConstantsBufferFactory sphereFragmentConstantsBufferFactory,
            ISphereInstancesBufferFactory sphereInstancesBufferFactory,
            ISphereVertexConstantsBufferFactory sphereVertexConstantsBufferFactory,
            ISphereGraphicsPipelineFactory sphereGraphicsPipelineFactory,
            IResourceLayoutDescriptionFactory resourceLayoutDescriptionFactory,
            IResourceLayoutElementDescriptionFactory resourceLayoutElementDescriptionFactory,
            ISphereFragmentResourceLayoutFactory sphereFragmentResourceLayoutFactory,
            ISphereVertexResourceLayoutFactory sphereVertexResourceLayoutFactory,
            IResourceSetDescriptionFactory resourceSetDescriptionFactory,
            IResourceSetFactory resourceSetFactory,
            IShaderDescriptionFactory shaderDescriptionFactory,
            ISphereFragmentShaderFactory sphereFragmentShaderFactory,
            ISphereShaderFactory sphereShaderFactory,
            ISphereVertexShaderFactory sphereVertexShaderFactory,
            GraphicsDevice graphicsDevice,
            int maximumInstancesPerDraw = 2048);
    }
}