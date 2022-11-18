namespace BeVelS.Graphics.Recorders.InterfacesFactories
{
    using Veldrid;

    using BeVelS.Graphics.Recorders.Interfaces;

    public interface IFrameRecorderFactory
    {
        IFrameRecorder Create(
            GraphicsDevice graphicsDevice,
            Texture sourceTexture);
    }
}