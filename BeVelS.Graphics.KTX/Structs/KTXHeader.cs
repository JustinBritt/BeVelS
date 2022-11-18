namespace BeVelS.Graphics.KTX.Structs
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct KTXHeader
    {
        public fixed byte Identifier[12];
        
        public readonly uint Endianness;

        public readonly uint GlType;
        
        public readonly uint GlTypeSize;
        
        public readonly uint GlFormat;
        
        public readonly uint GlInternalFormat;
        
        public readonly uint GlBaseInternalFormat;
        
        public readonly uint PixelWidth;
        
        private readonly uint _pixelHeight;
        
        public uint PixelHeight => Math.Max(
            1,
            _pixelHeight);
        
        public readonly uint PixelDepth;
        
        public readonly uint NumberOfArrayElements;
        
        public readonly uint NumberOfFaces;
        
        public readonly uint NumberOfMipmapLevels;
        
        public readonly uint BytesOfKeyValueData;
    }
}