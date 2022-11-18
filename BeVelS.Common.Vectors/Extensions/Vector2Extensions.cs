namespace BeVelS.Common.Vectors.Extensions
{
    using System.Numerics;

    using BepuUtilities;

    public static class Vector2Extensions
    {
        public static Int2 ToInt2(
            this Vector2 value)
        {
            Int2 int2 = default;
            
            int2.X = (int)value.X;

            int2.Y = (int)value.Y;

            return int2;
        }
    }
}