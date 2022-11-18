namespace BeVelS.Common.Vectors.InterfacesFactories
{
    using System.Numerics;

    public interface IVector3Factory
    {
        Vector3 Create();

        Vector3 Create(
            float x,
            float y,
            float z);

        Vector3 Create(
            Vector2 xy,
            float z);
    }
}