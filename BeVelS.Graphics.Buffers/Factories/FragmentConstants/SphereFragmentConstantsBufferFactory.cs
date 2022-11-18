namespace BeVelS.Graphics.Buffers.Factories.FragmentConstants
{
    using System;
    using System.Runtime.CompilerServices;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.BufferConstants.Structs.FragmentConstants;
    using BeVelS.Graphics.Buffers.Classes;
    using BeVelS.Graphics.Buffers.Extensions;
    using BeVelS.Graphics.Buffers.Interfaces;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Buffers.InterfacesFactories.FragmentConstants;

    internal sealed class SphereFragmentConstantsBufferFactory : ISphereFragmentConstantsBufferFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SphereFragmentConstantsBufferFactory()
        {
        }

        public unsafe IConstantsBuffer<SphereFragmentConstants> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice)
        {
            IConstantsBuffer<SphereFragmentConstants> constantsBuffer = null;

            try
            {
                constantsBuffer = new ConstantsBuffer<SphereFragmentConstants>(
                    graphicsDevice.ResourceFactory.CreateBuffer(
                        bufferDescriptionFactory.Create(
                            Unsafe.SizeOf<SphereFragmentConstants>().RoundUpToPowerOf2(
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