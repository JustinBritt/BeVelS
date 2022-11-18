namespace BeVelS.Graphics.Fonts.InterfacesFactories
{
    using Veldrid;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Fonts.Interfaces;

    public interface IFontFactory
    {
        IFont Create(
            IVector2Factory vector2Factory,
            IBufferDescriptionFactory bufferDescriptionFactory,
            IFontContent fontContent,
            GraphicsDevice graphicsDevice);
    }
}