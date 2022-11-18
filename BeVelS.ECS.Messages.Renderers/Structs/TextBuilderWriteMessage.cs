namespace BeVelS.ECS.Messages.Renderers.Structs
{
    using System.Numerics;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.Fonts.Interfaces;
    using BeVelS.Graphics.Text.Interfaces;

    public struct TextBuilderWriteMessage
    {
        public TextBuilderWriteMessage(
            IVector2Factory vector2Factory,
            IVector4Factory vector4Factory,
            Vector3 color,
            IFont font,
            float height,
            Vector2 horizontalAxis,
            Vector2 targetPosition,
            ITextBuilder textBuilder)
        {
            this.Vector2Factory = vector2Factory;

            this.Vector4Factory = vector4Factory;

            this.Color = color;

            this.Font = font;

            this.Height = height;

            this.HorizontalAxis = horizontalAxis;

            this.TargetPosition = targetPosition;

            this.TextBuilder = textBuilder;
        }

        public IVector2Factory Vector2Factory { get; }

        public IVector4Factory Vector4Factory { get; }

        public Vector3 Color { get; }

        public IFont Font { get; }

        public float Height { get; }

        public Vector2 HorizontalAxis { get; }

        public Vector2 TargetPosition { get; }

        public ITextBuilder TextBuilder { get; }
    }
}