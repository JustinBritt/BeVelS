namespace BeVelS.Physics.Constraints.Classes
{
    using System.Numerics;

    using BepuPhysics;

    using BepuUtilities;
    using BepuUtilities.Collections;

    using BeVelS.Common.OrthonormalBasisBuilders.Classes;

    using BeVelS.Graphics.Utilities.Classes;

    using BeVelS.Licensing.Classes;

    using BeVelS.Physics.Constraints.Structs.Lines;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/Constraints/ContactLineExtractor.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Use ColorUtilities")]
    public static class ContactLines
    {
        public static void Add(
            in RigidPose poseA,
            ref Vector3Wide offsetAWide,
            ref Vector3Wide normalWide,
            ref Vector<float> depthWide,
            in Vector3 tint,
            ref QuickList<LineInstance> lines)
        {
            Vector3Wide.ReadFirst(
                offsetAWide,
                out Vector3 offsetA);

            Vector3Wide.ReadFirst(
                normalWide,
                out Vector3 normal);

            float depth = depthWide[0];

            Vector3 contactPosition = offsetA + poseA.Position;

            Duff2017OrthonormalBasisBuilder.BuildOrthonormalBasis(
                normal,
                out Vector3 t1,
                out Vector3 t2);

            uint packedColor = ColorUtilities.PackColor(
                tint * (depth >= 0 ? new Vector3(0, 1, 0) : new Vector3(0.15f, 0.25f, 0.15f)));

            t1 *= 0.5f;

            t2 *= 0.5f;

            LineInstance t1Line = new LineInstance(
                contactPosition - t1,
                contactPosition + t1,
                packedColor, 0);

            lines.AddUnsafely(
                t1Line);

            LineInstance t2Line = new LineInstance(
                contactPosition - t2,
                contactPosition + t2,
                packedColor,
                0);

            lines.AddUnsafely(
                t2Line);
        }
    }
}