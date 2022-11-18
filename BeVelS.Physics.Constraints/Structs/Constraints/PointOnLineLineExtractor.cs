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
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/Constraints/PointOnLineLineExtractor.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Use ColorUtilities")]
    public struct PointOnLineLineExtractor : IConstraintLineExtractor<PointOnLineServoPrestepData>
    {
        public int LinesPerConstraint => 4;

        public unsafe void ExtractLines(
            ref PointOnLineServoPrestepData prestepBundle,
            int setIndex,
            int * bodyIndices,
            Bodies bodies,
            ref Vector3 tint,
            ref QuickList<LineInstance> lines)
        {
            //Could do bundles of constraints at a time, but eh.
            ref var poseA = ref bodies.Sets[setIndex].DynamicsState[bodyIndices[0]].Motion.Pose;
            
            ref var poseB = ref bodies.Sets[setIndex].DynamicsState[bodyIndices[1]].Motion.Pose;
            
            Vector3Wide.ReadFirst(
                prestepBundle.LocalOffsetA,
                out var localOffsetA);
            
            Vector3Wide.ReadFirst(
                prestepBundle.LocalOffsetB,
                out var localOffsetB);
            
            Vector3Wide.ReadFirst(
                prestepBundle.LocalDirection, 
                out var localDirection);
            
            QuaternionEx.Transform(
                localOffsetA,
                poseA.Orientation,
                out var worldOffsetA);
            
            QuaternionEx.Transform(
                localDirection,
                poseA.Orientation,
                out var worldDirection);
            
            QuaternionEx.Transform(
                localOffsetB,
                poseB.Orientation,
                out var worldOffsetB);

            var anchorA = poseA.Position + worldOffsetA;
            
            var anchorB = poseB.Position + worldOffsetB;
            
            var closestPointOnLine = Vector3.Dot(anchorB - anchorA, worldDirection) * worldDirection + anchorA;

            var color = new Vector3(0.2f, 0.2f, 1f) * tint;
            
            var packedColor = ColorUtilities.PackColor(
                color);
            
            var backgroundColor = new Vector3(0f, 0f, 1f) * tint;
            
            lines.AllocateUnsafely() = new LineInstance(
                poseA.Position,
                anchorA,
                packedColor,
                0);
            
            lines.AllocateUnsafely() = new LineInstance(
                anchorA,
                closestPointOnLine,
                packedColor,
                0);
            
            lines.AllocateUnsafely() = new LineInstance(
                closestPointOnLine,
                anchorB,
                ColorUtilities.PackColor(
                    new Vector3(1, 0, 0) * tint),
                0);
            
            lines.AllocateUnsafely() = new LineInstance(
                anchorB,
                poseB.Position,
                packedColor, 0);
        }
    }
}