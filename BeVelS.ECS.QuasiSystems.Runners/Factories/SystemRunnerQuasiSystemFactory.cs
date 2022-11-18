namespace BeVelS.ECS.QuasiSystems.Runners.Factories
{
    using System;

    using log4net;

    using DefaultEcs;
    using DefaultEcs.System;

    using BeVelS.Common.Stopwatches.InterfacesFactories;
    using BeVelS.Common.Threading.InterfacesFactories.Tasks;

    using BeVelS.ECS.QuasiSystems.Runners.Classes;
    using BeVelS.ECS.QuasiSystems.Runners.Interfaces;
    using BeVelS.ECS.QuasiSystems.Runners.InterfacesFactories;
    
    internal sealed class SystemRunnerQuasiSystemFactory : ISystemRunnerQuasiSystemFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SystemRunnerQuasiSystemFactory()
        {
        }

        public ISystemRunnerQuasiSystem Create<T>(
            IStopwatchStateFactory stopwatchStateFactory,
            ICancellableTaskFactory cancellableTaskFactory,
            ISystem<T> system,
            World world)
        {
            ISystemRunnerQuasiSystem quasiSystem = null;

            try
            {
                quasiSystem = new SystemRunnerQuasiSystem<T>(
                    stopwatchStateFactory,
                    cancellableTaskFactory,
                    system,
                    world);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return quasiSystem;
        }
    }
}