namespace BeVelS.Graphics.Buffers.Factories
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.Buffers.Classes;
    using BeVelS.Graphics.Buffers.Interfaces;
    using BeVelS.Graphics.Buffers.InterfacesFactories;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;

    internal sealed class IndexBufferFactory : IIndexBufferFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IndexBufferFactory()
        {
        }

        public IIndexBuffer<uint> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            uint[] indices)
        {
            IIndexBuffer<uint> indexBuffer = null;

            try
            {
                indexBuffer = new IndexBuffer<uint>(
                    graphicsDevice.ResourceFactory.CreateBuffer(
                        bufferDescriptionFactory.Create(
                            (uint)(indices.Length * sizeof(uint)),
                            BufferUsage.IndexBuffer)),
                    IndexFormat.UInt32,
                    indices);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return indexBuffer;
        }

        public IIndexBuffer<ushort> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            ushort[] indices)
        {
            IIndexBuffer<ushort> indexBuffer = null;

            try
            {
                indexBuffer = new IndexBuffer<ushort>(
                    graphicsDevice.ResourceFactory.CreateBuffer(
                        bufferDescriptionFactory.Create(
                            (uint)(indices.Length * sizeof(ushort)),
                            BufferUsage.IndexBuffer)),
                    IndexFormat.UInt16,
                    indices);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return indexBuffer;
        }
    }
}