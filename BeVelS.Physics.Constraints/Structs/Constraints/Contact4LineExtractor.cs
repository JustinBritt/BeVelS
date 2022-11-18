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
    public struct Contact4LineExtractor : IConstraintLineExtractor<Contact4PrestepData>
    {
        public int LinesPerConstraint => 8;

        public unsafe void ExtractLines(
            ref Contact4PrestepData prestepBundle,
            int setIndex,
            int * bodyIndices,
            Bodies bodies,
            ref Vector3 tint,
            ref QuickList<LineInstance> lines)
        {
            ref var poseA = ref bodies.Sets[setIndex].DynamicsState[bodyIndices[0]].Motion.Pose;
            
            ContactLines.Add(
                poseA, 
                ref prestepBundle.Contact0.OffsetA,
                ref prestepBundle.Normal,
                ref prestepBundle.Contact0.Depth, 
                tint, 
                ref lines);
            
            ContactLines.Add(
                poseA, 
                ref prestepBundle.Contact1.OffsetA, 
                ref prestepBundle.Normal, 
                ref prestepBundle.Contact1.Depth, 
                tint, 
                ref lines);
            
            ContactLines.Add(
                poseA, 
                ref prestepBundle.Contact2.OffsetA,
                ref prestepBundle.Normal, 
                ref prestepBundle.Contact2.Depth, 
                tint, 
                ref lines);
            
            ContactLines.Add(
                poseA, 
                ref prestepBundle.Contact3.OffsetA,
                ref prestepBundle.Normal, 
                ref prestepBundle.Contact3.Depth,
                tint,
                ref lines);
        }
    }
}