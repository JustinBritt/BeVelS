namespace BeVelS.Common.Threading.Classes.Tasks
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using BeVelS.Common.Threading.Interfaces.Tasks;

    internal sealed class CancellableTask : ICancellableTask
    {
        public CancellableTask(
            Action action)
        {
            this.CancellationTokenSource = new CancellationTokenSource();

            this.CancellationToken = this.CancellationTokenSource.Token;

            this.Task = Task.Run(
                action,
                this.CancellationToken);
        }

        public CancellationToken CancellationToken { get; }

        public CancellationTokenSource CancellationTokenSource { get; }

        public Task Task { get; }

        public void Cancel()
        {
            this.CancellationTokenSource.Cancel();
        }
    }
}