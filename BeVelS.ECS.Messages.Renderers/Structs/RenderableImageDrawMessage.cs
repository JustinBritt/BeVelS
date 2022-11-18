namespace BeVelS.ECS.Messages.Renderers.Structs
{
    using System.Numerics;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.Images.Interfaces;
    using BeVelS.Graphics.Images.InterfacesFactories;

    public struct RenderableImageDrawMessage
    {
        public RenderableImageDrawMessage(
            IVector2Factory vector2Factory,
            IImageInstanceFactory imageInstanceFactory,
            IRenderableImage renderableImage,
            Vector2 size,
            Vector2 targetPosition)
        {
            this.Vector2Factory = vector2Factory;

            this.ImageInstanceFactory = imageInstanceFactory;

            this.RenderableImage = renderableImage;

            this.Size = size;

            this.TargetPosition = targetPosition;
        }

        public IVector2Factory Vector2Factory { get; }

        public IImageInstanceFactory ImageInstanceFactory { get; }

        public IRenderableImage RenderableImage { get; }

        public Vector2 Size { get; }

        public Vector2 TargetPosition { get; }
    }
}