namespace BeVelS.Graphics.Buffers.Factories.Instances
{
    using System;
    using System.Runtime.CompilerServices;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.Buffers.Classes;
    using BeVelS.Graphics.Buffers.Interfaces;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Instances;
    using BeVelS.Graphics.Glyphs.Structs;

    internal sealed class GlyphInstancesBufferFactory : IGlyphInstancesBufferFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public GlyphInstancesBufferFactory()
        {
        }

        public unsafe IInstancesBuffer<GlyphInstance> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            int maximumGlyphsPerDraw)
        {
            IInstancesBuffer<GlyphInstance> instancesBuffer = null;

            try
            {
                instancesBuffer = new InstancesBuffer<GlyphInstance>(
                    graphicsDevice.ResourceFactory.CreateBuffer(
                        bufferDescriptionFactory.Create(
                            (uint)(maximumGlyphsPerDraw * Unsafe.SizeOf<GlyphInstance>()),
                            BufferUsage.StructuredBufferReadOnly,
                            (uint)(Unsafe.SizeOf<GlyphInstance>()))));
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instancesBuffer;
        }
    }
}