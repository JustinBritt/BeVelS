namespace BeVelS.Graphics.Buffers.Extensions
{
    public static class IntExtensions
    {
        public static uint RoundUpToPowerOf2(
            this int value,
            int exponent = 1)
        {
            return (uint)((((value - 1) >> exponent) + 1) << exponent);
        }
    }
}