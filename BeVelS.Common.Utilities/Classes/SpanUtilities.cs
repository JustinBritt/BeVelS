namespace BeVelS.Common.Utilities.Classes
{
    using System;

    using BepuUtilities.Memory;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoUtilities/SpanConverter.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges)]
    public static unsafe class SpanUtilities
    {
        public static unsafe Span<T> AsSpan<T>(
            in Buffer<T> buffer) 
            where T : unmanaged
        {
            return new Span<T>(
                buffer.Memory,
                buffer.Length);
        }
    }
}