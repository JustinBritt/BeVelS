namespace BeVelS.Graphics.BackgroundRenderers.InterfacesFactories
{
    using Veldrid;

    using BeVelS.Graphics.BackgroundRenderers.Interfaces;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Buffers.InterfacesFactories.VertexConstants;
    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.VertexResourceLayouts;
    using BeVelS.Graphics.ResourceSets.InterfacesFactories;
    using BeVelS.Graphics.ResourceSets.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories;
    using BeVelS.Graphics.Shaders.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories.FragmentShaders;
    using BeVelS.Graphics.Shaders.InterfacesFactories.VertexShaders;

    public interface IBackgroundRendererFactory
    {
        IBackgroundRenderer Create(
            IBackgroundVertexConstantsBufferFactory backgroundVertexConstantsBufferFactory,
            IBufferDescriptionFactory bufferDescriptionFactory,
            IBackgroundVertexResourceLayoutFactory backgroundVertexResourceLayoutFactory,
            IResourceLayoutDescriptionFactory resourceLayoutDescriptionFactory,
            IResourceLayoutElementDescriptionFactory resourceLayoutElementDescriptionFactory,
            IResourceSetDescriptionFactory resourceSetDescriptionFactory,
            IResourceSetFactory resourceSetFactory,
            IBackgroundFragmentShaderFactory backgroundFragmentShaderFactory,
            IBackgroundShaderFactory backgroundShaderFactory,
            IBackgroundVertexShaderFactory backgroundVertexShaderFactory,
            IShaderDescriptionFactory shaderDescriptionFactory,
            GraphicsDevice graphicsDevice);
    }
}