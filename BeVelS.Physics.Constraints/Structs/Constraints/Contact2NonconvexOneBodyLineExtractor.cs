namespace BeVelS.Physics.Constraints.Structs.Constraints
{
    using System.Numerics;

    using BepuPhysics;
    using BepuPhysics.Constraints.Contact;

    using BepuUtilities.Collections;

    using BeVelS.Licensing.Classes;

    using BeVelS.Physics.Constraints.Classes;
    using BeVelS.Physics.Constraints.Interfaces;
    using BeVelS.Physics.Constraints.Structs.Lines;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/Constraints/ContactLineExtractors.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges)]
    public struct Contact2NonconvexOneBodyLineExtractor : IConstraintLineExtractor<Contact2NonconvexOneBodyPrestepData>
    {
        public int LinesPerConstraint => 4;

        public unsafe void ExtractLines(
            ref Contact2NonconvexOneBodyPrestepData prestepBundle,
            int setIndex,
            int * bodyIndices,
            Bodies bodies,
            ref Vector3 tint,
            ref QuickList<LineInstance> lines)
        {
            ref var poseA = ref bodies.Sets[setIndex].DynamicsState[bodyIndices[0]].Motion.Pose;
            
            ContactLines.Add(
                poseA,
                ref prestepBundle.Contact0.Offset,
                ref prestepBundle.Contact0.Normal,
                ref prestepBundle.Contact0.Depth,
                tint,
                ref lines);

            ContactLines.Add(
                poseA,
                ref prestepBundle.Contact1.Offset, 
                ref prestepBundle.Contact1.Normal, 
                ref prestepBundle.Contact1.Depth,
                tint,
                ref lines);
        }
    }
}