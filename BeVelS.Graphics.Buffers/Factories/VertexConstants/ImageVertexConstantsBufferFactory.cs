﻿namespace BeVelS.Graphics.Buffers.Factories.VertexConstants
{
    using System;
    using System.Runtime.CompilerServices;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.BufferConstants.Structs.VertexConstants;
    using BeVelS.Graphics.Buffers.Classes;
    using BeVelS.Graphics.Buffers.Extensions;
    using BeVelS.Graphics.Buffers.Interfaces;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Buffers.InterfacesFactories.VertexConstants;

    internal sealed class ImageVertexConstantsBufferFactory : IImageVertexConstantsBufferFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ImageVertexConstantsBufferFactory()
        {
        }

        public unsafe IConstantsBuffer<ImageVertexConstants> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice)
        {
            IConstantsBuffer<ImageVertexConstants> constantsBuffer = null;

            try
            {
                constantsBuffer = new ConstantsBuffer<ImageVertexConstants>(
                    graphicsDevice.ResourceFactory.CreateBuffer(
                        bufferDescriptionFactory.Create(
                            Unsafe.SizeOf<ImageVertexConstants>().RoundUpToPowerOf2(
                                4),
                            BufferUsage.UniformBuffer
                            |
                            BufferUsage.Dynamic)));
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return constantsBuffer;
        }
    }
}