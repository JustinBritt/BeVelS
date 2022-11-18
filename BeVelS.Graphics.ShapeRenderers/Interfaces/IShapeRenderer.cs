namespace BeVelS.Graphics.ShapeRenderers.Interfaces
{
    using System;

    using BepuUtilities;

    using Veldrid;

    using BeVelS.Graphics.Cameras.Interfaces;
    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.ResourceSets.InterfacesFactories;
    using BeVelS.Graphics.ResourceSets.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.ShaderSets.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shapes.Interfaces;

    public interface IShapeRenderer : IDisposable
    {
        void PreparePipeline(
            IGraphicsPipelineDescriptionFactory graphicsPipelineDescriptionFactory,
            IShaderSetDescriptionFactory shaderSetDescriptionFactory,
            BlendStateDescription blendStateDescription,
            DepthStencilStateDescription depthStencilStateDescription,
            GraphicsDevice graphicsDevice,
            OutputDescription outputDescription,
            RasterizerStateDescription rasterizerStateDescription);

        void Render<TShape>(
            IResourceSetDescriptionFactory resourceSetDescriptionFactory,
            IResourceSetFactory resourceSetFactory,
            ICamera camera,
            CommandList commandList,
            int count,
            GraphicsDevice graphicsDevice,
            ReadOnlySpan<TShape> instances,
            Sampler[] samplers,
            Int2 screenResolution,
            Texture[] textures)
            where TShape : unmanaged, IShapeInstance;
    }
}