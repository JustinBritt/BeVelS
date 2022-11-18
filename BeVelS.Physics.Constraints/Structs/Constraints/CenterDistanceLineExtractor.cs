namespace BeVelS.Physics.Constraints.Structs.Constraints
{
    using System.Numerics;

    using BepuUtilities;
    using BepuUtilities.Collections;

    using BepuPhysics;
    using BepuPhysics.Constraints;

    using BeVelS.Graphics.Utilities.Classes;

    using BeVelS.Licensing.Classes;

    using BeVelS.Physics.Constraints.Interfaces;
    using BeVelS.Physics.Constraints.Structs.Lines;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/Constraints/CenterDistanceLineExtractor.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Use ColorUtilities")]
    public struct CenterDistanceLineExtractor : IConstraintLineExtractor<CenterDistancePrestepData>
    {
        public int LinesPerConstraint => 2;


        public unsafe void ExtractLines(
            ref CenterDistancePrestepData prestepBundle,
            int setIndex,
            int * bodyIndices,
            Bodies bodies,
            ref Vector3 tint,
            ref QuickList<LineInstance> lines)
        {
            //Could do bundles of constraints at a time, but eh.
            ref var poseA = ref bodies.Sets[setIndex].DynamicsState[bodyIndices[0]].Motion.Pose;

            ref var poseB = ref bodies.Sets[setIndex].DynamicsState[bodyIndices[1]].Motion.Pose;
            
            var targetDistance = GatherScatter.GetFirst(
                ref prestepBundle.TargetDistance);
            
            var color = new Vector3(0.2f, 0.2f, 1f) * tint;
            
            var packedColor = ColorUtilities.PackColor(
                color);
            
            var backgroundColor = new Vector3(0f, 0f, 1f) * tint;
            
            //Draw a line from A to B. If the true distance is longer than the target distance, draw a red line to complete the gap.
            //If the true distance is shorter than the target distance, draw an overshooting red line.
            var offset = poseB.Position - poseA.Position;
            
            var length = offset.Length();
            
            var direction = length < 1e-9f ? new Vector3(1, 0, 0) : offset / length;
            
            var errorColor = new Vector3(1, 0, 0) * tint;
            
            var packedErrorColor = ColorUtilities.PackColor(
                errorColor);
            
            var packedDistanceColor = ColorUtilities.PackColor(
                color * 0.5f);
            
            var targetEnd = poseA.Position + direction * targetDistance;
            
            if (length < targetDistance)
            {
                lines.AllocateUnsafely() = new LineInstance(
                    poseA.Position,
                    poseB.Position,
                    packedDistanceColor,
                    0);
            
                lines.AllocateUnsafely() = new LineInstance(
                    poseB.Position,
                    targetEnd,
                    packedErrorColor,
                    0);
            }
            else
            {
                lines.AllocateUnsafely() = new LineInstance(
                    poseA.Position,
                    targetEnd,
                    packedDistanceColor,
                    0);
                
                lines.AllocateUnsafely() = new LineInstance(
                    targetEnd,
                    poseB.Position,
                    packedErrorColor,
                    0);
            }
        }
    }
}