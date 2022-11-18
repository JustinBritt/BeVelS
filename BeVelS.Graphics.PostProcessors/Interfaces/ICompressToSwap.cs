namespace BeVelS.Graphics.PostProcessors.Interfaces
{
    using System;

    using Veldrid;

    using BeVelS.Graphics.ResourceSets.InterfacesFactories.Descriptions;

    public interface ICompressToSwap : IDisposable
    {
        void Render(
            IResourceSetDescriptionFactory resourceSetDescriptionFactory,
            TextureView colorTextureView,
            CommandList commandList,
            GraphicsDevice graphicsDevice);
    }
}