namespace BeVelS.ECS.Messages.Renderers.InterfacesFactories
{
    using System.Numerics;

    using BeVelS.ECS.Messages.Renderers.Structs;

    public interface IUILineDrawMessageFactory
    {
        UILineDrawMessage Create(
            Vector3 color,
            Vector2 end,
            float radius,
            Vector2 start);
    }
}