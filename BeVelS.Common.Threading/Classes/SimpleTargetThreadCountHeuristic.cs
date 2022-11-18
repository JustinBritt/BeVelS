namespace BeVelS.Common.Threading.Classes
{
    using System;

    using BeVelS.Common.Threading.Interfaces;
    using BeVelS.Common.Threading.InterfacesFactories;

    using BeVelS.Licensing.Classes;

    internal sealed class SimpleTargetThreadCountHeuristic : ISimpleTargetThreadCountHeuristic
    {
        public SimpleTargetThreadCountHeuristic()
        {
        }

        [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/Demos/Demo.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges)]
        public IThreadCount Estimate(
            IThreadCountFactory threadCountFactory)
        {
            return threadCountFactory.Create(
                Math.Max(1, Environment.ProcessorCount > 4 ? Environment.ProcessorCount - 2 : Environment.ProcessorCount - 1));
        }
    }
}