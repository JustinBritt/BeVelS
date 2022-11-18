namespace BeVelS.Graphics.Textures.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.Textures.Interfaces;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoContentLoader/Texture2DContent.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Renamed Texture2DContent to TextureContent",
        "Added Dimensions")]
    internal sealed class TextureContent : ITextureContent
    {
        GCHandle handle;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TextureContent(
            IVector2Factory vector2Factory,
            int width,
            int height,
            int mipLevels,
            int texelSizeInBytes)
        {
            this.Width = width;

            this.Height = height;

            this.MipLevels = mipLevels;

            this.TexelSizeInBytes = texelSizeInBytes;

            int dataSize = 0;

            List<int> dataSizes = new List<int>();

            List<Vector2> dimensions = new List<Vector2>();

            for (int i = 0; i < mipLevels; ++i)
            {
                int curr = texelSizeInBytes * (width >> i) * (height >> i);

                dataSize += curr;

                dataSizes.Add(
                    curr);

                dimensions.Add(
                    vector2Factory.Create(
                        (width >> i),
                        (height >> i)));
            }

            this.Data = new byte[dataSize];

            this.DataSize = dataSizes.ToArray();

            this.Dimensions = dimensions.ToArray();
        }

        public byte[] Data { get; private set; }

        public int[] DataSize { get; private set; }

        public Vector2[] Dimensions { get; private set; }

        public int Height { get; private set; }

        public int MipLevels { get; private set; }

        public int TexelSizeInBytes { get; private set; }

        public int Width { get; private set; }

        // Note that all of these operate in units of texels, not bytes.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int GetRowPitch(
            int mipLevel)
        {
            Debug.Assert(
                mipLevel >= 0 && mipLevel < MipLevels);

            return (Width >> mipLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int GetMipStartIndex(
            int mipLevel)
        {
            Debug.Assert(
                mipLevel >= 0 && mipLevel < MipLevels);

            int start = 0;

            for (int i = 0; i < mipLevel; ++i)
            {
                start += (Width >> i) * (Height >> i);
            }

            return start;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int GetRowOffsetFromMipStart(
            int mipLevel,
            int rowIndex)
        {
            Debug.Assert(
                mipLevel >= 0 && mipLevel < MipLevels);

            Debug.Assert(
                rowIndex >= 0 && rowIndex < (Height >> mipLevel));

            return GetRowPitch(mipLevel) * rowIndex;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int GetOffset(
            int columnIndex,
            int rowIndex,
            int mipLevel)
        {
            Debug.Assert(
                mipLevel >= 0 && mipLevel < MipLevels);

            Debug.Assert(
                columnIndex >= 0 && columnIndex < Width && rowIndex >= 0 && rowIndex < Height);

            return GetMipStartIndex(mipLevel) + GetRowPitch(mipLevel) * rowIndex + columnIndex;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int GetOffsetForMip0(
            int columnIndex,
            int rowIndex)
        {
            Debug.Assert(
                columnIndex >= 0 && columnIndex < Width && rowIndex >= 0 && rowIndex < Height);

            return Width * rowIndex + columnIndex;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int GetRowOffsetForMip0(
            int rowIndex)
        {
            Debug.Assert(
                rowIndex >= 0 && rowIndex < Height);

            return Width * rowIndex;
        }

        public unsafe byte * Pin()
        {
            if (handle.IsAllocated)
                throw new InvalidOperationException(
                    "Cannot pin an already-pinned texture.");

            handle = GCHandle.Alloc(
                Data,
                GCHandleType.Pinned);
            
            return (byte*)handle.AddrOfPinnedObject();
        }

        public void Unpin()
        {
            if (!handle.IsAllocated)
                throw new InvalidOperationException(
                    "Should only unpin textures that have been pinned.");

            handle.Free();
        }
    }
}