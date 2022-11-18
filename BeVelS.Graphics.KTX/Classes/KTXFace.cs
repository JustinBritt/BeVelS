namespace BeVelS.Graphics.KTX.Classes
{
    using BeVelS.Graphics.KTX.Interfaces;

    using BeVelS.Licensing.Classes;

    [VeldridLicensedCode(
        boilerplate: VeldridLicensedCodeAttribute.MITLicenseBoilerplate,
        copyrightOwner: VeldridLicensedCodeAttribute.VeldridCopyrightOwner,
        copyrightYears: VeldridLicensedCodeAttribute.VeldridCopyrightYears,
        source: "https://github.com/mellinoe/veldrid-samples/blob/master/src/SampleBase/KtxFile.cs")]
    internal sealed class KTXFace : IKTXFace
    {
        public KTXFace(
            byte[] data)
        {
            this.Data = data;
        }

        public byte[] Data { get; }
    }
}