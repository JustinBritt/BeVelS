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
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/Constraints/BallSocketMotorLineExtractor.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Use ColorUtilities")]
    public struct BallSocketMotorLineExtractor : IConstraintLineExtractor<BallSocketMotorPrestepData>
    {
        public int LinesPerConstraint => 2;

        public unsafe void ExtractLines(
            ref BallSocketMotorPrestepData prestepBundle,
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
                prestepBundle.LocalOffsetB,
                out var localOffsetB);
            
            QuaternionEx.Transform(
                localOffsetB,
                poseB.Orientation,
                out var worldOffsetB);
            
            var anchor = poseB.Position + worldOffsetB;
            
            var color = new Vector3(0.2f, 0.2f, 1f) * tint;
            
            var packedColor = ColorUtilities.PackColor(
                color);
            
            var backgroundColor = new Vector3(0f, 0f, 1f) * tint;
            
            lines.AllocateUnsafely() = new LineInstance(
                poseA.Position,
                anchor,
                packedColor,
                0);
            
            lines.AllocateUnsafely() = new LineInstance(
                poseB.Position,
                anchor,
                packedColor,
                0);
        }
    }
}