﻿namespace BeVelS.Graphics.Buffers.InterfacesFactories.FragmentConstants
{
    using Veldrid;

    using BeVelS.Graphics.BufferConstants.Structs.FragmentConstants;
    using BeVelS.Graphics.Buffers.Interfaces;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;

    public interface ICapsuleFragmentConstantsBufferFactory
    {
        unsafe IConstantsBuffer<CapsuleFragmentConstants> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice);
    }
}