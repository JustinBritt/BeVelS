namespace BeVelS.Graphics.GraphDataSeries.Structs
{
    using System.Numerics;

    using BeVelS.Graphics.GraphDataSeries.Interfaces;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/Demos/UI/Graph.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges)]
    public struct Series
    {
        // The use of a string here blocks the use of unmanaged storage. Not a big deal; drawing a Graph isn't exactly performance critical.
        public string Name;

        public Vector3 LineColor;

        public float LineRadius;

        public IDataSeries Data;
    }
}