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

    public interface ICapsuleRendererFactory
    {
        ICapsuleRenderer Create(
            IVector2Factory vector2Factory,
            ICapsuleFragmentConstantsFactory capsuleFragmentConstantsFactory,
            ICapsuleVertexConstantsFactory capsuleVertexConstantsFactory,
            IBufferDescriptionFactory bufferDescriptionFactory,
            ICapsuleFragmentConstantsBufferFactory capsuleFragmentConstantsBufferFactory,
            ICapsuleInstancesBufferFactory capsuleInstancesBufferFactory,
            ICapsuleVertexConstantsBufferFactory capsuleVertexConstantsBufferFactory,
            IIndexBufferFactory indexBufferFactory,
            ICapsuleGraphicsPipelineFactory capsuleGraphicsPipelineFactory,
            ICapsuleFragmentResourceLayoutFactory capsuleFragmentResourceLayoutFactory,
            ICapsuleVertexResourceLayoutFactory capsuleVertexResourceLayoutFactory,
            IResourceLayoutDescriptionFactory resourceLayoutDescriptionFactory,
            IResourceLayoutElementDescriptionFactory resourceLayoutElementDescriptionFactory,
            IResourceSetDescriptionFactory resourceSetDescriptionFactory,
            IResourceSetFactory resourceSetFactory,
            ICapsuleFragmentShaderFactory capsuleFragmentShaderFactory,
            ICapsuleShaderFactory capsuleShaderFactory,
            ICapsuleVertexShaderFactory capsuleVertexShaderFactory,
            IShaderDescriptionFactory shaderDescriptionFactory,
            GraphicsDevice graphicsDevice,
            int maximumInstancesPerDraw = 256);
    }
}