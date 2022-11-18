namespace BeVelS.Graphics.KTX.Classes
{
    using BeVelS.Graphics.KTX.Interfaces;

    using BeVelS.Licensing.Classes;

    [VeldridLicensedCode(
        boilerplate: VeldridLicensedCodeAttribute.MITLicenseBoilerplate,
        copyrightOwner: VeldridLicensedCodeAttribute.VeldridCopyrightOwner,
        copyrightYears: VeldridLicensedCodeAttribute.VeldridCopyrightYears,
        source: "https://github.com/mellinoe/veldrid-samples/blob/master/src/SampleBase/KtxFile.cs")]
    internal sealed class KTXArrayElement : IKTXArrayElement
    {
        public KTXArrayElement(
            IKTXFace[] faces)
        {
            this.Faces = faces;
        }

        public IKTXFace[] Faces { get; }
    }
}