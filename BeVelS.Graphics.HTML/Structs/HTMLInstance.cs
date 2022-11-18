namespace BeVelS.Graphics.HTML.Structs
{
    using System.Diagnostics;
    using System.Numerics;
    using System.Runtime.CompilerServices;

    using BeVelS.Graphics.Utilities.Classes;

    public struct HTMLInstance
    {
        public uint PackedMinimum;

        public uint PackedHorizontalAxis;

        public uint PackedSize;

        public uint PackedColor;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public HTMLInstance(
            in Vector2 start,
            in Vector2 horizontalAxis,
            in Vector2 size,
            in Vector4 color,
            in Vector2 screenToPackedScale)
        {
            this.PackedMinimum = (uint)(start.X * screenToPackedScale.X) | ((uint)(start.Y * screenToPackedScale.Y) << 16);

            uint scaledAxisX = (uint)(horizontalAxis.X * 32767f + 32767f);

            uint scaledAxisY = (uint)(horizontalAxis.Y * 32767f + 32767f);

            Debug.Assert(
                scaledAxisX <= 65534);

            Debug.Assert(
                scaledAxisY <= 65534);

            this.PackedHorizontalAxis = scaledAxisX | (scaledAxisY << 16);

            const float sizeScale = 65535f / 4096f;

            Vector2 scaledSize = size * sizeScale;

            Vector2 clampedSize = Vector2.Max(
                Vector2.Zero,
                Vector2.Min(
                    new Vector2(65535f),
                    scaledSize));

            this.PackedSize = (uint)clampedSize.X | (((uint)clampedSize.Y) << 16);

            this.PackedColor = ColorUtilities.PackColor(
                color);
        }
    }
}