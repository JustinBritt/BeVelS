namespace BeVelS.Physics.Constraints.Structs.Constraints
{
    using System.Numerics;

    using BepuPhysics;
    using BepuPhysics.Constraints;

    using BepuUtilities;
    using BepuUtilities.Collections;

    using BeVelS.Graphics.Utilities.Classes;

    using BeVelS.Licensing.Classes;

    using BeVelS.Physics.Constraints.Interfaces;
    using BeVelS.Physics.Constraints.Structs.Lines;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/Constraints/CenterDistanceLimitLineExtractor.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Use ColorUtilities")]
    public struct CenterDistanceLimitLineExtractor : IConstraintLineExtractor<CenterDistanceLimitPrestepData>
    {
        public int LinesPerConstraint => 5;

        public unsafe void ExtractLines(
            ref CenterDistanceLimitPrestepData prestepBundle,
            int setIndex, 
            int * bodyIndices,
            Bodies bodies,
            ref Vector3 tint,
            ref QuickList<LineInstance> lines)
        {
            //Could do bundles of constraints at a time, but eh.
            ref var poseA = ref bodies.Sets[setIndex].DynamicsState[bodyIndices[0]].Motion.Pose;

            ref var poseB = ref bodies.Sets[setIndex].DynamicsState[bodyIndices[1]].Motion.Pose;
            
            var minimumDistance = GatherScatter.GetFirst(
                ref prestepBundle.MinimumDistance);
            
            var maximumDistance = GatherScatter.GetFirst(
                ref prestepBundle.MaximumDistance);
            
            var color = new Vector3(0.2f, 0.2f, 1f) * tint;
            
            var packedColor = ColorUtilities.PackColor(
                color);
            
            var backgroundColor = new Vector3(0f, 0f, 1f) * tint;
            
            lines.AllocateUnsafely() = new LineInstance(
                poseA.Position,
                poseA.Position, 
                packedColor,
                0);
            
            lines.AllocateUnsafely() = new LineInstance(
                poseB.Position,
                poseB.Position,
                packedColor,
                0);
            
            var offset = poseB.Position - poseA.Position;
            
            var length = offset.Length();
            
            var direction = length < 1e-9f ? new Vector3(1, 0, 0) : offset / length;
            
            var errorColor = new Vector3(1, 0, 0) * tint;
            
            var packedErrorColor = ColorUtilities.PackColor(
                errorColor);
            
            var packedFarColor = ColorUtilities.PackColor(
                color * 0.5f);
            
            var packedNearColor = ColorUtilities.PackColor(
                color * 0.25f);
            
            var minimumPoint = poseA.Position + direction * minimumDistance;
            
            if (length >= minimumDistance && length <= maximumDistance)
            {
                // Create a darker bar to signify the minimum limit.
                lines.AllocateUnsafely() = new LineInstance(
                    poseA.Position,
                    minimumPoint,
                    packedNearColor,
                    0);
            
                lines.AllocateUnsafely() = new LineInstance(
                    minimumPoint,
                    poseB.Position,
                    packedFarColor,
                    0);
                
                lines.AllocateUnsafely() = new LineInstance(
                    new Vector3(
                        float.MinValue),
                    new Vector3(
                        float.MinValue),
                    0,
                    0);

            }
            else if (length < minimumDistance)
            {
                // Too close; draw an error line extending beyond the connecting line.
                lines.AllocateUnsafely() = new LineInstance(
                    poseA.Position,
                    poseB.Position,
                    packedNearColor,
                    0);
                
                lines.AllocateUnsafely() = new LineInstance(
                    poseB.Position,
                    poseA.Position + direction * minimumDistance,
                    packedErrorColor,
                    0);
                
                lines.AllocateUnsafely() = new LineInstance(
                    new Vector3(
                        float.MinValue),
                    new Vector3(
                        float.MinValue),
                    0,
                    0);
            }
            else
            {
                // Too far; draw an error line that extends from the desired endpoint to the current endpoint.
                var targetEnd = poseA.Position + direction * maximumDistance;
                
                lines.AllocateUnsafely() = new LineInstance(
                    poseA.Position,
                    minimumPoint,
                    packedNearColor,
                    0);
                
                lines.AllocateUnsafely() = new LineInstance(
                    minimumPoint,
                    targetEnd,
                    packedFarColor,
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