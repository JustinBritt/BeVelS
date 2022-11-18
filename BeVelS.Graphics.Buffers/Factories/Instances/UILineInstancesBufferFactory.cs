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
    using BeVelS.Graphics.UILines.Structs;

    internal sealed class UILineInstancesBufferFactory : IUILineInstancesBufferFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public UILineInstancesBufferFactory()
        {
        }

        public unsafe IInstancesBuffer<UILineInstance> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            int maximumLinesPerDraw)
        {
            IInstancesBuffer<UILineInstance> instancesBuffer = null;

            try
            {
                instancesBuffer = new InstancesBuffer<UILineInstance>(
                    graphicsDevice.ResourceFactory.CreateBuffer(
                        bufferDescriptionFactory.Create(
                            (uint)(maximumLinesPerDraw * Unsafe.SizeOf<UILineInstance>()),
                            BufferUsage.StructuredBufferReadOnly,
                            (uint)(Unsafe.SizeOf<UILineInstance>()))));
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