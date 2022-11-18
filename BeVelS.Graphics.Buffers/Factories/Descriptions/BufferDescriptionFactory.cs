namespace BeVelS.Graphics.Buffers.Factories.Descriptions
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;

    internal sealed class BufferDescriptionFactory : IBufferDescriptionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BufferDescriptionFactory()
        {
        }

        public BufferDescription Create(
            uint sizeInBytes,
            BufferUsage usage)
        {
            BufferDescription bufferDescription = default;

            try
            {
                bufferDescription = new BufferDescription(
                    sizeInBytes,
                    usage);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return bufferDescription;
        }

        public BufferDescription Create(
            uint sizeInBytes,
            BufferUsage usage,
            uint structureByteStride)
        {
            BufferDescription bufferDescription = default;

            try
            {
                bufferDescription = new BufferDescription(
                    sizeInBytes,
                    usage,
                    structureByteStride);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return bufferDescription;
        }

        public BufferDescription Create(
            uint sizeInBytes,
            BufferUsage usage,
            uint structureByteStride,
            bool rawBuffer)
        {
            BufferDescription bufferDescription = default;

            try
            {
                bufferDescription = new BufferDescription(
                    sizeInBytes,
                    usage,
                    structureByteStride,
                    rawBuffer);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return bufferDescription;
        }
    }
}