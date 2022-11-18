namespace BeVelS.Graphics.UIRenderers.Interfaces
{
    using System.Numerics;

    using BepuUtilities;

    using Veldrid;

    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Instances;

    public interface IUILineBatchRenderer
    {
        Int2 Resolution { set; }

        void Draw(
            in Vector2 start,
            in Vector2 end,
            float radius,
            in Vector3 color);

        void Flush(
            IBufferDescriptionFactory bufferDescriptionFactory,
            IUILineInstancesBufferFactory UILineInstancesBufferFactory,
            CommandList commandList,
            GraphicsDevice graphicsDevice,
            Int2 screenResolution,
            IUILineRenderer renderer);
    }
}