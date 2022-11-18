namespace BeVelS.Graphics.LineRenderers.InterfacesFactories
{
    using Veldrid;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.BufferConstants.InterfacesFactories.VertexConstants;
    using BeVelS.Graphics.Buffers.InterfacesFactories;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Instances;
    using BeVelS.Graphics.Buffers.InterfacesFactories.VertexConstants;
    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories;
    using BeVelS.Graphics.LineRenderers.Interfaces;
    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.VertexResourceLayouts;
    using BeVelS.Graphics.ResourceSets.InterfacesFactories;
    using BeVelS.Graphics.ResourceSets.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories;
    using BeVelS.Graphics.Shaders.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories.FragmentShaders;
    using BeVelS.Graphics.Shaders.InterfacesFactories.VertexShaders;

    public interface ILineRendererFactory
    {
        ILineRenderer Create(
            IVector2Factory vector2Factory,
            ILineVertexConstantsFactory lineVertexConstantsFactory,
            IBufferDescriptionFactory bufferDescriptionFactory,
            IIndexBufferFactory indexBufferFactory,
            ILineInstancesBufferFactory lineInstancesBufferFactory,
            ILineVertexConstantsBufferFactory lineVertexConstantsBufferFactory,
            ILineGraphicsPipelineFactory lineGraphicsPipelineFactory,
            ILineVertexResourceLayoutFactory lineVertexResourceLayoutFactory,
            IResourceLayoutDescriptionFactory resourceLayoutDescriptionFactory,
            IResourceLayoutElementDescriptionFactory resourceLayoutElementDescriptionFactory,
            IResourceSetDescriptionFactory resourceSetDescriptionFactory,
            IResourceSetFactory resourceSetFactory,
            ILineFragmentShaderFactory lineFragmentShaderFactory,
            ILineShaderFactory lineShaderFactory,
            ILineVertexShaderFactory lineVertexShaderFactory,
            IShaderDescriptionFactory shaderDescriptionFactory,
            GraphicsDevice graphicsDevice,
            int maximumInstancesPerDraw = 16384);
    }
}