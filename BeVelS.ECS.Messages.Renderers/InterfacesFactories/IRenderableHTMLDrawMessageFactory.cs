namespace BeVelS.ECS.Messages.Renderers.InterfacesFactories
{
    using System.Numerics;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.ECS.Messages.Renderers.Structs;

    using BeVelS.Graphics.HTML.Interfaces;
    using BeVelS.Graphics.HTML.InterfacesFactories;

    public interface IRenderableHTMLDrawMessageFactory
    {
        RenderableHTMLDrawMessage Create(
            IVector2Factory vector2Factory,
            IHTMLInstanceFactory HTMLInstanceFactory,
            Vector4 color,
            IRenderableHTML renderableHTML,
            Vector2 size,
            Vector2 targetPosition);
    }
}