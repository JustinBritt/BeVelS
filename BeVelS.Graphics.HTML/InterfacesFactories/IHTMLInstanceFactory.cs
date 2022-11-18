namespace BeVelS.Graphics.HTML.InterfacesFactories
{
    using System.Numerics;

    using BeVelS.Graphics.HTML.Structs;

    public interface IHTMLInstanceFactory
    {
        HTMLInstance Create(
            Vector2 start,
            Vector2 horizontalAxis,
            Vector2 size,
            Vector4 color,
            Vector2 screenToPackedScale);
    }
}