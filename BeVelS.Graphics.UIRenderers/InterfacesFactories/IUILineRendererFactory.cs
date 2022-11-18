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
    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.VertexResourceLayouts;
    using BeVelS.Graphics.ResourceSets.InterfacesFactories;
    using BeVelS.Graphics.ResourceSets.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories;
    using BeVelS.Graphics.Shaders.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories.FragmentShaders;
    using BeVelS.Graphics.Shaders.InterfacesFactories.VertexShaders;
    using BeVelS.Graphics.UIRenderers.Interfaces;

    public interface IUILineRendererFactory
    {
        IUILineRenderer Create(
            IVector2Factory vector2Factory,
            IUILineVertexConstantsFactory UILineVertexConstantsFactory,
            IBufferDescriptionFactory bufferDescriptionFactory,
            IIndexBufferFactory indexBufferFactory,
            IUILineInstancesBufferFactory UILineInstancesBufferFactory,
            IUILineVertexConstantsBufferFactory UILineVertexConstantsBufferFactory,
            IUILineGraphicsPipelineFactory UILineGraphicsPipelineFactory,
            IResourceLayoutDescriptionFactory resourceLayoutDescriptionFactory,
            IResourceLayoutElementDescriptionFactory resourceLayoutElementDescriptionFactory,
            IUILineVertexResourceLayoutFactory UILineVertexResourceLayoutFactory,
            IResourceSetDescriptionFactory resourceSetDescriptionFactory,
            IResourceSetFactory resourceSetFactory,
            IShaderDescriptionFactory shaderDescriptionFactory,
            IUILineFragmentShaderFactory UILineFragmentShaderFactory,
            IUILineShaderFactory UILineShaderFactory,
            IUILineVertexShaderFactory UILineVertexShaderFactory,
            GraphicsDevice graphicsDevice,
            int maximumLinesPerDraw = 2048);
    }
}