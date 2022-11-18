namespace BeVelS.Graphics.KTX.Classes
{
    using BeVelS.Graphics.KTX.Interfaces;

    using BeVelS.Licensing.Classes;

    [VeldridLicensedCode(
        boilerplate: VeldridLicensedCodeAttribute.MITLicenseBoilerplate,
        copyrightOwner: VeldridLicensedCodeAttribute.VeldridCopyrightOwner,
        copyrightYears: VeldridLicensedCodeAttribute.VeldridCopyrightYears,
        source: "https://github.com/mellinoe/veldrid-samples/blob/master/src/SampleBase/KtxFile.cs")]
    internal sealed class KTXKeyValuePair : IKTXKeyValuePair
    {
        public KTXKeyValuePair(
            string key,
            byte[] value)
        {
            this.Key = key;

            this.Value = value;
        }

        public string Key { get; }

        public byte[] Value { get; }
    }
}