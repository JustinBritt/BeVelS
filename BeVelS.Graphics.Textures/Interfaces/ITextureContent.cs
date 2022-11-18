namespace BeVelS.Graphics.Textures.Interfaces
{
    using System.Numerics;

    public interface ITextureContent
    {
        byte[] Data { get; }

        int[] DataSize { get; }

        Vector2[] Dimensions { get; }

        int Height { get; }

        int MipLevels { get; }

        int TexelSizeInBytes { get; }

        int Width { get; }

        int GetMipStartIndex(
            int mipLevel);

        int GetOffset(
            int columnIndex,
            int rowIndex,
            int mipLevel);

        int GetRowOffsetForMip0(
            int rowIndex);

        int GetRowOffsetFromMipStart(
            int mipLevel,
            int rowIndex);

        int GetRowPitch(
            int mipLevel);

        unsafe byte* Pin();

        void Unpin();
    }
}