namespace BeVelS.Graphics.Buffers.Factories.VertexConstants
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

    internal sealed class CapsuleVertexConstantsBufferFactory : ICapsuleVertexConstantsBufferFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CapsuleVertexConstantsBufferFactory()
        {
        }

        public unsafe IConstantsBuffer<CapsuleVertexConstants> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice)
        {
            IConstantsBuffer<CapsuleVertexConstants> constantsBuffer = null;

            try
            {
                constantsBuffer = new ConstantsBuffer<CapsuleVertexConstants>(
                    graphicsDevice.ResourceFactory.CreateBuffer(
                        bufferDescriptionFactory.Create(
                            Unsafe.SizeOf<CapsuleVertexConstants>().RoundUpToPowerOf2(
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