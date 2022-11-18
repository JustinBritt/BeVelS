namespace BeVelS.ECS.Messages.Renderers.InterfacesFactories
{
    using System.Numerics;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.ECS.Messages.Renderers.Structs;

    using BeVelS.Graphics.Fonts.Interfaces;
    using BeVelS.Graphics.Text.Interfaces;

    public interface ITextBuilderWriteMessageFactory
    {
        TextBuilderWriteMessage Create(
            IVector2Factory vector2Factory,
            IVector4Factory vector4Factory,
            Vector3 color,
            IFont font,
            float height,
            Vector2 horizontalAxis,
            Vector2 targetPosition,
            ITextBuilder textBuilder);
    }
}