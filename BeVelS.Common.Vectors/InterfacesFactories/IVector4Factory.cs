namespace BeVelS.Common.Vectors.InterfacesFactories
{
    using System.Numerics;

    public interface IVector4Factory
    {
        Vector4 Create(
            float x,
            float y,
            float z,
            float w);

        Vector4 Create(
            Vector3 xyz,
            float w);
    }
}