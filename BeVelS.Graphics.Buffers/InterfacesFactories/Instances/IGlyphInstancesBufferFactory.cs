namespace BeVelS.Graphics.Buffers.InterfacesFactories.Instances
{
    using Veldrid;

    using BeVelS.Graphics.Buffers.Interfaces;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Glyphs.Structs;

    public interface IGlyphInstancesBufferFactory
    {
        unsafe IInstancesBuffer<GlyphInstance> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            int maximumGlyphsPerDraw);
    }
}