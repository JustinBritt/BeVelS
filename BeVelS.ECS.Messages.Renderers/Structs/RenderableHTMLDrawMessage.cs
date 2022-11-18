namespace BeVelS.ECS.Messages.Renderers.Structs
{
    using System.Numerics;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.HTML.Interfaces;
    using BeVelS.Graphics.HTML.InterfacesFactories;

    public struct RenderableHTMLDrawMessage
    {
        public RenderableHTMLDrawMessage(
            IVector2Factory vector2Factory,
            IHTMLInstanceFactory HTMLInstanceFactory,
            Vector4 color,
            IRenderableHTML renderableHTML,
            Vector2 size,
            Vector2 targetPosition)
        {
            this.Vector2Factory = vector2Factory;

            this.HTMLInstanceFactory = HTMLInstanceFactory;

            this.Color = color;

            this.RenderableHTML = renderableHTML;

            this.Size = size;

            this.TargetPosition = targetPosition;
        }

        public IVector2Factory Vector2Factory { get; }

        public IHTMLInstanceFactory HTMLInstanceFactory { get; }

        public Vector4 Color { get; }

        public IRenderableHTML RenderableHTML { get; }

        public Vector2 Size { get; }

        public Vector2 TargetPosition { get; }
    }
}