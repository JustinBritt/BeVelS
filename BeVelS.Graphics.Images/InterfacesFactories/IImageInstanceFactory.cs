namespace BeVelS.Graphics.Images.InterfacesFactories
{
    using System.Numerics;

    using BeVelS.Graphics.Images.Structs;

    public interface IImageInstanceFactory
    {
        ImageInstance Create(
            Vector2 start,
            Vector2 horizontalAxis,
            Vector2 size,
            Vector4 color,
            Vector2 screenToPackedScale);
    }
}