namespace BeVelS.Common.Threading.Structs
{
    using System.Threading;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/547d3e28c5181b48bc1b077ff89f3f8d06ac8818/Demos/SimpleThreadDispatcher.cs")]
    public struct Worker
    {
        public Thread Thread;

        public AutoResetEvent Signal;
    }
}