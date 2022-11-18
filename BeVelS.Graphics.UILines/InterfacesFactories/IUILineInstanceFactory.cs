namespace BeVelS.Graphics.UILines.InterfacesFactories
{
    using System.Numerics;

    using BeVelS.Graphics.UILines.Structs;

    public interface IUILineInstanceFactory
    {
        UILineInstance Create(
            Vector3 color,
            Vector2 end,
            float radius,
            Vector2 screenToPackedScale,
            Vector2 start);
    }
}