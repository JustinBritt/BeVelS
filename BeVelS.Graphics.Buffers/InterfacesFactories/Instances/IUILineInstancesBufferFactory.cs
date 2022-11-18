namespace BeVelS.Graphics.Buffers.InterfacesFactories.Instances
{
    using Veldrid;

    using BeVelS.Graphics.Buffers.Interfaces;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.UILines.Structs;

    public interface IUILineInstancesBufferFactory
    {
        unsafe IInstancesBuffer<UILineInstance> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            int maximumLinesPerDraw);
    }
}