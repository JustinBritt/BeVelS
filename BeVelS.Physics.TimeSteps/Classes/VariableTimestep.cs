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
    internal sealed class VariableTimestep : IVariableTimestep
    {
        float timeAccumulator;

        public VariableTimestep()
        {
        }

        public void Timestep(
            float dt,
            Simulation simulation,
            float targetTimestepDuration,
            IThreadDispatcher threadDispatcher)
        {
            this.timeAccumulator += dt;

            while (this.timeAccumulator >= targetTimestepDuration)
            {
                simulation.Timestep(
                    targetTimestepDuration,
                    threadDispatcher);

                this.timeAccumulator -= targetTimestepDuration;
            }

            float interpolationWeight = this.timeAccumulator / targetTimestepDuration;
        }
    }
}