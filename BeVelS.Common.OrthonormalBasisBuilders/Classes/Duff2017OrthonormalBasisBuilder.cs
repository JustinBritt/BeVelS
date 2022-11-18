namespace BeVelS.Common.OrthonormalBasisBuilders.Classes
{
    using System.Numerics;
    using System.Runtime.CompilerServices;

    public static class Duff2017OrthonormalBasisBuilder
    {
        // Duff et al. (2017)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void BuildOrthonormalBasis(
            in Vector3 n,
            out Vector3 b1,
            out Vector3 b2)
        {
            if (n.Z < 0)
            {
                float a = 1.0f / (1.0f - n.Z);

                float b = n.X * n.Y * a;

                b1 = new Vector3(
                    1.0f - n.X * n.X * a,
                    -b,
                    n.X);

                b2 = new Vector3(
                    b,
                    n.Y * n.Y * a - 1.0f,
                    -n.Y);
            }
            else
            {
                float a = 1.0f / (1.0f + n.Z);

                float b = -n.X * n.Y * a;

                b1 = new Vector3(
                    1.0f - n.X * n.X * a,
                    b,
                    -n.X);

                b2 = new Vector3(
                    b,
                    1.0f - n.Y * n.Y * a,
                    -n.Y);
            }
        }
    }
}