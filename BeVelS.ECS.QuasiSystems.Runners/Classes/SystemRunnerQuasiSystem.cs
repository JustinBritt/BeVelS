namespace BeVelS.ECS.QuasiSystems.Runners.Classes
{
    using System;

    using DefaultEcs;
    using DefaultEcs.System;

    using BeVelS.Common.Stopwatches.Interfaces;
    using BeVelS.Common.Stopwatches.InterfacesFactories;
    using BeVelS.Common.Threading.Interfaces.Tasks;
    using BeVelS.Common.Threading.InterfacesFactories.Tasks;

    using BeVelS.ECS.QuasiSystems.Runners.Interfaces;
    
    internal sealed class SystemRunnerQuasiSystem<T> : ISystemRunnerQuasiSystem
    {
        public SystemRunnerQuasiSystem(
            IStopwatchStateFactory stopwatchStateFactory,
            ICancellableTaskFactory cancellableTaskFactory,
            ISystem<T> system,
            World world)
        {
            this.World = world;

            this.World.Subscribe(
                this);

            this.System = system;

            this.StopwatchState = stopwatchStateFactory.Create();

            this.CancellableTask = cancellableTaskFactory.Create(
                () =>
                {
                    this.Update();
                });
        }

        public ICancellableTask CancellableTask { get; }

        public bool IsEnabled { get; set; }

        private IStopwatchState StopwatchState { get; }

        private ISystem<T> System { get; }

        private World World { get; }

        public void Update()
        {
            this.StopwatchState.StartNew();

            while (!this.CancellableTask.CancellationTokenSource.IsCancellationRequested)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ((ISystem<decimal>)this.System).Update(
                        this.StopwatchState.GetStateAsdecimal());
                }
                else if (typeof(T) == typeof(double))
                {
                    ((ISystem<double>)this.System).Update(
                        this.StopwatchState.GetStateAsdouble());
                }
                else if (typeof(T) == typeof(float))
                {
                    ((ISystem<float>)this.System).Update(
                        this.StopwatchState.GetStateAsfloat());
                }
                else if (typeof(T) == typeof(long))
                {
                    ((ISystem<long>)this.System).Update(
                        this.StopwatchState.GetStateAslong());
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;
            }
        }
    }
}