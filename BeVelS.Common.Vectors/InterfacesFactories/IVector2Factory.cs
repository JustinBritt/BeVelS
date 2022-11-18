namespace BeVelS.Common.Vectors.InterfacesFactories
{
    using System.Numerics;

    public interface IVector2Factory
    {
        Vector2 Create(
            float value);

        Vector2 Create(
            float x,
            float y);
    }
}