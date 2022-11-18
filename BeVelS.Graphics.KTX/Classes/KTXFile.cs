namespace BeVelS.Graphics.KTX.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Text;

    using Veldrid;

    using BeVelS.Graphics.KTX.Interfaces;
    using BeVelS.Graphics.KTX.InterfacesFactories;
    using BeVelS.Graphics.KTX.Structs;

    using BeVelS.Licensing.Classes;

    [VeldridLicensedCode(
        boilerplate: VeldridLicensedCodeAttribute.MITLicenseBoilerplate,
        copyrightOwner: VeldridLicensedCodeAttribute.VeldridCopyrightOwner,
        copyrightYears: VeldridLicensedCodeAttribute.VeldridCopyrightYears,
        source: "https://github.com/mellinoe/veldrid-samples/blob/master/src/SampleBase/KtxFile.cs")]
    // A hand-crafted KTX file parser.
    // https://www.khronos.org/opengles/sdk/tools/KTX/file_format_spec
    internal sealed class KTXFile : IKTXFile
    {
        public KTXFile(
            KTXHeader header,
            IKTXKeyValuePair[] keyValuePairs,
            IKTXMipmapLevel[] mipmaps)
        {
            this.Header = header;

            this.KeyValuePairs = keyValuePairs;

            this.Mipmaps = mipmaps;
        }

        public KTXHeader Header { get; }

        public IKTXKeyValuePair[] KeyValuePairs { get; }

        public IKTXMipmapLevel[] Mipmaps { get; }

        public static IKTXFile Load(
            IKTXArrayElementFactory KTXArrayElementFactory,
            IKTXFaceFactory KTXFaceFactory,
            IKTXFileFactory KTXFileFactory,
            IKTXKeyValuePairFactory KTXKeyValuePairFactory,
            IKTXMipmapLevelFactory KTXMipmapLevelFactory,
            byte[] bytes,
            bool readKeyValuePairs)
        {
            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                return Load(
                    KTXArrayElementFactory,
                    KTXFaceFactory,
                    KTXFileFactory,
                    KTXKeyValuePairFactory,
                    KTXMipmapLevelFactory,
                    memoryStream,
                    readKeyValuePairs);
            }
        }

        public static IKTXFile Load(
            IKTXArrayElementFactory KTXArrayElementFactory,
            IKTXFaceFactory KTXFaceFactory,
            IKTXFileFactory KTXFileFactory,
            IKTXKeyValuePairFactory KTXKeyValuePairFactory,
            IKTXMipmapLevelFactory KTXMipmapLevelFactory,
            Stream stream,
            bool readKeyValuePairs)
        {
            using (BinaryReader binaryReader = new BinaryReader(stream))
            {
                KTXHeader header = ReadStruct<KTXHeader>(
                    binaryReader);

                IKTXKeyValuePair[] kvps = null;

                if (readKeyValuePairs)
                {
                    int keyValuePairBytesRead = 0;
                
                    List<IKTXKeyValuePair> keyValuePairs = new List<IKTXKeyValuePair>();
                    
                    while (keyValuePairBytesRead < header.BytesOfKeyValueData)
                    {
                        int bytesRemaining = (int)(header.BytesOfKeyValueData - keyValuePairBytesRead);
                    
                        IKTXKeyValuePair kvp = ReadNextKeyValuePair(
                            KTXKeyValuePairFactory,
                            binaryReader,
                            out int read);
                        
                        keyValuePairBytesRead += read;
                        
                        keyValuePairs.Add(
                            kvp);
                    }

                    kvps = keyValuePairs.ToArray();
                }
                else
                {
                    // Skip over header data.
                    binaryReader.BaseStream.Seek(
                        header.BytesOfKeyValueData,
                        SeekOrigin.Current); 
                }

                uint numberOfMipmapLevels = Math.Max(
                    1,
                    header.NumberOfMipmapLevels);

                uint numberOfArrayElements = Math.Max(
                    1,
                    header.NumberOfArrayElements);
                
                uint numberOfFaces = Math.Max(
                    1,
                    header.NumberOfFaces);

                uint baseWidth = Math.Max(
                    1,
                    header.PixelWidth);

                uint baseHeight = Math.Max(
                    1,
                    header.PixelHeight);

                uint baseDepth = Math.Max(
                    1,
                    header.PixelDepth);

                IKTXMipmapLevel[] images = new IKTXMipmapLevel[numberOfMipmapLevels];

                for (int mip = 0; mip < numberOfMipmapLevels; mip++)
                {
                    uint mipWidth = Math.Max(
                        1,
                        baseWidth / (uint)(Math.Pow(2, mip)));
                
                    uint mipHeight = Math.Max(
                        1,
                        baseHeight / (uint)(Math.Pow(2, mip)));
                    
                    uint mipDepth = Math.Max(
                        1,
                        baseDepth / (uint)(Math.Pow(2, mip)));

                    uint imageSize = binaryReader.ReadUInt32();
                    
                    uint arrayElementSize = imageSize / numberOfArrayElements;
                    
                    IKTXArrayElement[] arrayElements = new IKTXArrayElement[numberOfArrayElements];
                    
                    for (int arr = 0; arr < numberOfArrayElements; arr++)
                    {
                        uint faceSize = arrayElementSize / numberOfFaces;

                        IKTXFace[] faces = new IKTXFace[numberOfFaces];
                        
                        for (int face = 0; face < numberOfFaces; face++)
                        {
                            faces[face] = KTXFaceFactory.Create(
                                binaryReader.ReadBytes(
                                    (int)faceSize));
                        }

                        arrayElements[arr] = KTXArrayElementFactory.Create(
                            faces);
                    }

                    images[mip] = KTXMipmapLevelFactory.Create(
                        width: mipWidth,
                        height: mipHeight,
                        depth: mipDepth,
                        totalSize: imageSize,
                        arraySliceSize: arrayElementSize,
                        slices: arrayElements);

                    uint mipPaddingBytes = 3 - ((imageSize + 3) % 4);

                    binaryReader.BaseStream.Seek(
                        mipPaddingBytes,
                        SeekOrigin.Current);
                }

                return KTXFileFactory.Create(
                    header,
                    kvps,
                    images);
            }
        }

        private static unsafe IKTXKeyValuePair ReadNextKeyValuePair(
            IKTXKeyValuePairFactory KTXKeyValuePairFactory,
            BinaryReader binaryReader,
            out int bytesRead)
        {
            uint keyAndValueByteSize = binaryReader.ReadUInt32();

            byte * keyAndValueBytes = stackalloc byte[(int)keyAndValueByteSize];
            
            ReadBytes(
                binaryReader,
                keyAndValueBytes,
                (int)keyAndValueByteSize);
            
            int paddingByteCount = (int)(3 - ((keyAndValueByteSize + 3) % 4));

            // Skip padding bytes
            binaryReader.BaseStream.Seek(
                paddingByteCount,
                SeekOrigin.Current); 

            // Find the key's null terminator
            int i;

            for (i = 0; i < keyAndValueByteSize; i++)
            {
                if (keyAndValueBytes[i] == 0)
                {
                    break;
                }

                // Fail
                Debug.Assert(
                    i != keyAndValueByteSize); 
            }


            // Don't include null terminator.
            int keySize = i; 

            string key = Encoding.UTF8.GetString(
                keyAndValueBytes,
                keySize);

            // Skip null terminator
            byte * valueStart = keyAndValueBytes + i + 1; 
            
            int valueSize = (int)(keyAndValueByteSize - keySize - 1);
            
            byte[] value = new byte[valueSize];
            
            for (int v = 0; v < valueSize; v++)
            {
                value[v] = valueStart[v];
            }

            bytesRead = (int)(keyAndValueByteSize + paddingByteCount + sizeof(uint));

            return KTXKeyValuePairFactory.Create(
                key,
                value);
        }

        private static unsafe T ReadStruct<T>(
            BinaryReader binaryReader)
        {
            int size = Unsafe.SizeOf<T>();

            byte* bytes = stackalloc byte[size];

            for (int i = 0; i < size; i++)
            {
                bytes[i] = binaryReader.ReadByte();
            }

            return Unsafe.Read<T>(
                bytes);
        }

        private static unsafe void ReadBytes(
            BinaryReader binaryReader,
            byte * destination,
            int count)
        {
            for (int i = 0; i < count; i++)
            {
                destination[i] = binaryReader.ReadByte();
            }
        }

        public static unsafe Texture LoadTexture(
            IKTXArrayElementFactory KTXArrayElementFactory,
            IKTXFaceFactory KTXFaceFactory,
            IKTXFileFactory KTXFileFactory,
            IKTXKeyValuePairFactory KTXKeyValuePairFactory,
            IKTXMipmapLevelFactory KTXMipmapLevelFactory,
            GraphicsDevice graphicsDevice,
            byte[] bytes,
            PixelFormat pixelFormat)
        {
            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                return LoadTexture(
                    KTXArrayElementFactory,
                    KTXFaceFactory,
                    KTXFileFactory,
                    KTXKeyValuePairFactory,
                    KTXMipmapLevelFactory,
                    graphicsDevice,
                    memoryStream,
                    pixelFormat);
            }
        }

        public static unsafe Texture LoadTexture(
            IKTXArrayElementFactory KTXArrayElementFactory,
            IKTXFaceFactory KTXFaceFactory,
            IKTXFileFactory KTXFileFactory,
            IKTXKeyValuePairFactory KTXKeyValuePairFactory,
            IKTXMipmapLevelFactory KTXMipmapLevelFactory,
            GraphicsDevice graphicsDevice,
            string assetPath,
            PixelFormat pixelFormat)
        {
            using (FileStream fileStream = File.OpenRead(assetPath))
            {
                return LoadTexture(
                    KTXArrayElementFactory,
                    KTXFaceFactory,
                    KTXFileFactory,
                    KTXKeyValuePairFactory,
                    KTXMipmapLevelFactory,
                    graphicsDevice,
                    fileStream,
                    pixelFormat);
            }
        }

        public static unsafe Texture LoadTexture(
            IKTXArrayElementFactory KTXArrayElementFactory,
            IKTXFaceFactory KTXFaceFactory,
            IKTXFileFactory KTXFileFactory,
            IKTXKeyValuePairFactory KTXKeyValuePairFactory,
            IKTXMipmapLevelFactory KTXMipmapLevelFactory,
            GraphicsDevice graphicsDevice,
            Stream assetStream,
            PixelFormat pixelFormat)
        {
            IKTXFile ktxTex2D = Load(
                KTXArrayElementFactory,
                KTXFaceFactory,
                KTXFileFactory,
                KTXKeyValuePairFactory,
                KTXMipmapLevelFactory,
                assetStream,
                false);

            uint width = ktxTex2D.Header.PixelWidth;
            
            uint height = ktxTex2D.Header.PixelHeight;
            
            if (height == 0) height = width;

            uint arrayLayers = Math.Max(
                1,
                ktxTex2D.Header.NumberOfArrayElements);
            
            uint mipLevels = Math.Max(
                1,
                ktxTex2D.Header.NumberOfMipmapLevels);

            Texture ret = graphicsDevice.ResourceFactory.CreateTexture(
                TextureDescription.Texture2D(
                    width,
                    height,
                    mipLevels,
                    arrayLayers,
                    pixelFormat,
                    TextureUsage.Sampled));

            Texture stagingTex = graphicsDevice.ResourceFactory.CreateTexture(
                TextureDescription.Texture2D(
                    width,
                    height,
                    mipLevels,
                    arrayLayers,
                    pixelFormat,
                    TextureUsage.Staging));

            // Copy texture data into staging buffer
            for (uint level = 0; level < mipLevels; level++)
            {
                IKTXMipmapLevel mipmap = ktxTex2D.Mipmaps[level];

                for (uint layer = 0; layer < arrayLayers; layer++)
                {
                    IKTXArrayElement ktxLayer = mipmap.ArrayElements[layer];
                
                    Debug.Assert(
                        ktxLayer.Faces.Length == 1);
                    
                    byte[] pixelData = ktxLayer.Faces[0].Data;

                    fixed (byte * pixelDataPtr = &pixelData[0])
                    {
                        graphicsDevice.UpdateTexture(
                            stagingTex,
                            (IntPtr)pixelDataPtr,
                            (uint)pixelData.Length,
                            0,
                            0,
                            0,
                            mipmap.Width,
                            mipmap.Height,
                            1,
                            level,
                            layer);
                    }
                }
            }

            CommandList copyCL = graphicsDevice.ResourceFactory.CreateCommandList();

            copyCL.Begin();
            
            for (uint level = 0; level < mipLevels; level++)
            {
                IKTXMipmapLevel mipLevel = ktxTex2D.Mipmaps[level];
            
                for (uint layer = 0; layer < arrayLayers; layer++)
                {
                    copyCL.CopyTexture(
                        stagingTex,
                        0,
                        0,
                        0,
                        level,
                        layer,
                        ret,
                        0,
                        0,
                        0,
                        level,
                        layer,
                        mipLevel.Width,
                        mipLevel.Height,
                        mipLevel.Depth,
                        1);
                }
            }

            copyCL.End();

            graphicsDevice.SubmitCommands(
                copyCL);

            graphicsDevice.DisposeWhenIdle(
                copyCL);
            
            graphicsDevice.DisposeWhenIdle(
                stagingTex);

            return ret;
        }
    }
}