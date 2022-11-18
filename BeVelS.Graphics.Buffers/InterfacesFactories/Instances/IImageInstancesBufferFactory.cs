namespace BeVelS.Graphics.Buffers.InterfacesFactories.Instances
{
    using Veldrid;

    using BeVelS.Graphics.Buffers.Interfaces;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Images.Structs;

    public interface IImageInstancesBufferFactory
    {
        unsafe IInstancesBuffer<ImageInstance> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            int maximumPerDraw);
    }
}