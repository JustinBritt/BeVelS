﻿namespace BeVelS.ECS.Components.RenderTargets.InterfacesFactories
{
    using Veldrid;

    using BeVelS.ECS.Components.RenderTargets.Structs;

    public interface IColorBufferComponentFactory
    {
        ColorBufferComponent Create(
            Texture value);
    }
}