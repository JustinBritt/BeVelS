namespace BeVelS.Graphics.Buffers.InterfacesFactories.Instances
{
    using Veldrid;

    using BeVelS.Graphics.Buffers.Interfaces;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.HTML.Structs;

    public interface IHTMLInstancesBufferFactory
    {
        IInstancesBuffer<HTMLInstance> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            int maximumPerDraw);
    }
}