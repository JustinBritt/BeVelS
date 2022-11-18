﻿namespace BeVelS.Graphics.ResourceLayouts.InterfacesFactories.VertexResourceLayouts
{
    using Veldrid;

    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.Descriptions;

    public interface ITriangleVertexResourceLayoutFactory
    {
        ResourceLayout Create(
            IResourceLayoutDescriptionFactory resourceLayoutDescriptionFactory,
            IResourceLayoutElementDescriptionFactory resourceLayoutElementDescriptionFactory,
            GraphicsDevice graphicsDevice);
    }
}