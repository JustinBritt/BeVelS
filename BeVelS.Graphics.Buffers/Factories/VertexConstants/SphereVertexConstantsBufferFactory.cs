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

    internal sealed class SphereVertexConstantsBufferFactory : ISphereVertexConstantsBufferFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SphereVertexConstantsBufferFactory()
        {
        }

        public unsafe IConstantsBuffer<SphereVertexConstants> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice)
        {
            IConstantsBuffer<SphereVertexConstants> constantsBuffer = null;

            try
            {
                constantsBuffer = new ConstantsBuffer<SphereVertexConstants>(
                    graphicsDevice.ResourceFactory.CreateBuffer(
                        bufferDescriptionFactory.Create(
                            Unsafe.SizeOf<SphereVertexConstants>().RoundUpToPowerOf2(
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