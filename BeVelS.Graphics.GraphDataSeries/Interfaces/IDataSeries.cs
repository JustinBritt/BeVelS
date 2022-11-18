namespace BeVelS.Graphics.GraphDataSeries.Interfaces
{
    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/Demos/UI/Graph.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges)]
    public interface IDataSeries
    {
        int Start { get; }

        int End { get; }

        double this[int index] { get; }
    }
}