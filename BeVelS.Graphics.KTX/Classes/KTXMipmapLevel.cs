namespace BeVelS.Graphics.KTX.Classes
{
    using BeVelS.Graphics.KTX.Interfaces;

    using BeVelS.Licensing.Classes;

    [VeldridLicensedCode(
        boilerplate: VeldridLicensedCodeAttribute.MITLicenseBoilerplate,
        copyrightOwner: VeldridLicensedCodeAttribute.VeldridCopyrightOwner,
        copyrightYears: VeldridLicensedCodeAttribute.VeldridCopyrightYears,
        source: "https://github.com/mellinoe/veldrid-samples/blob/master/src/SampleBase/KtxFile.cs")]
    internal sealed class KTXMipmapLevel : IKTXMipmapLevel
    {
        public KTXMipmapLevel(
            uint width,
            uint height,
            uint depth,
            uint totalSize,
            uint arraySliceSize,
            IKTXArrayElement[] slices)
        {
            this.Width = width;

            this.Height = height;

            this.Depth = depth;

            this.TotalSize = totalSize;

            this.ArrayElementSize = arraySliceSize;

            this.ArrayElements = slices;
        }

        public uint Width { get; }

        public uint Height { get; }

        public uint Depth { get; }

        public uint TotalSize { get; }

        public uint ArrayElementSize { get; }

        public IKTXArrayElement[] ArrayElements { get; }
    }
}