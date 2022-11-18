namespace BeVelS.Physics.Constraints.AbstractClasses.Constraints
{
    using BepuPhysics;
    using BepuPhysics.Constraints;

    using BepuUtilities.Collections;

    using BeVelS.Licensing.Classes;

    using BeVelS.Physics.Constraints.Structs.Lines;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/Constraints/ConstraintLineExtractor.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges)]
    public abstract class TypeLineExtractor
    {
        public abstract int LinesPerConstraint { get; }

        public abstract void ExtractLines(
            Bodies bodies,
            int setIndex,
            ref TypeBatch typeBatch,
            int constraintStart,
            int constraintCount,
            ref QuickList<LineInstance> lines);
    }
}