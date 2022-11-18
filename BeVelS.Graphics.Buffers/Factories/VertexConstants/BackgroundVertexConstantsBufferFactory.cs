namespace BeVelS.Graphics.Buffers.Factories.VertexConstants
{
    using System;
    using System.Numerics;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.Buffers.Classes;
    using BeVelS.Graphics.Buffers.Interfaces;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Buffers.InterfacesFactories.VertexConstants;

    internal sealed class BackgroundVertexConstantsBufferFactory : IBackgroundVertexConstantsBufferFactory
    {
        private const uint Matrix4x4SizeInBytes = 4 * 4 * sizeof(float);

        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BackgroundVertexConstantsBufferFactory()
        {
        }

        public IConstantsBuffer<Matrix4x4> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice)
        {
            IConstantsBuffer<Matrix4x4> constantsBuffer = null;

            try
            {
                constantsBuffer = new ConstantsBuffer<Matrix4x4>(
                    graphicsDevice.ResourceFactory.CreateBuffer(
                        bufferDescriptionFactory.Create(
                            Matrix4x4SizeInBytes,
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