namespace BeVelS.Physics.TimeSteps.Classes
{
    using BepuPhysics;

    using BepuUtilities;

    using BeVelS.Licensing.Classes;

    using BeVelS.Physics.TimeSteps.Interfaces;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/Demos/Demo.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges)]
    internal sealed class FixedTimestep : IFixedTimestep
    {
        public FixedTimestep()
        {
        }

        public void Timestep(
            Simulation simulation,
            IThreadDispatcher threadDispatcher,
            int timestepsPerUpdate,
            float timeToSimulate)
        {
            float timePerTimestep = timeToSimulate / timestepsPerUpdate;

            for (int i = 0; i < timestepsPerUpdate; i = i + 1)
            {
                simulation.Timestep(
                    timePerTimestep,
                    threadDispatcher);
            }
        }
    }
}