namespace BeVelS.ECS.Messages.Renderers.InterfacesFactories
{
    using System.Numerics;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.ECS.Messages.Renderers.Structs;

    using BeVelS.Graphics.Images.Interfaces;
    using BeVelS.Graphics.Images.InterfacesFactories;

    public interface IRenderableImageDrawMessageFactory
    {
        RenderableImageDrawMessage Create(
            IVector2Factory vector2Factory,
            IImageInstanceFactory imageInstanceFactory,
            IRenderableImage renderableImage,
            Vector2 size,
            Vector2 targetPosition);
    }
}