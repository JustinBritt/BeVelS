﻿namespace BeVelS.Physics.Constraints.Structs.Constraints
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
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/Constraints/WeldLineExtractor.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Use ColorUtilities")]
    public struct WeldLineExtractor : IConstraintLineExtractor<WeldPrestepData>
    {
        public int LinesPerConstraint => 2;

        public unsafe void ExtractLines(
            ref WeldPrestepData prestepBundle,
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
                prestepBundle.LocalOffset,
                out var localOffset);
            
            QuaternionEx.Transform(
                localOffset,
                poseA.Orientation,
                out var worldOffset);
            
            var bTarget = poseA.Position + worldOffset;
            
            var color = new Vector3(0.2f, 0.2f, 1f) * tint;
            
            var packedColor = ColorUtilities.PackColor(
                color);
            
            var backgroundColor = new Vector3(0f, 0f, 1f) * tint;
            
            lines.AllocateUnsafely() = new LineInstance(
                poseA.Position,
                bTarget,
                packedColor,
                0);
            
            var errorColor = new Vector3(1, 0, 0) * tint;
            
            var packedErrorColor = ColorUtilities.PackColor(
                errorColor);
            
            lines.AllocateUnsafely() = new LineInstance(
                bTarget,
                poseB.Position,
                packedErrorColor,
                0);
        }
    }
}