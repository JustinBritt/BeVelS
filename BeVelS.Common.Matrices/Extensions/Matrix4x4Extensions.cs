namespace BeVelS.Common.Matrices.Extensions
{
    using System.Numerics;

    public static class Matrix4x4Extensions
    {
        public static Matrix4x4 GetInverse(
            this Matrix4x4 value)
        {
            Matrix4x4 inverse;

            Matrix4x4.Invert(
                value,
                out inverse);

            return inverse;
        }
    }
}