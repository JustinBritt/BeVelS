namespace BeVelS.Graphics.Cameras.Enums
{
    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/Demos/DemoHarness.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges)]
    public enum CameraMoveSpeedState
    {
        Regular,
        Slow,
        Fast
    }
}