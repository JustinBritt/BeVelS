namespace BeVelS.Common.Threading.Interfaces.Tasks
{
    using System.Threading;
    using System.Threading.Tasks;
   
    public interface ICancellableTask
    {
        CancellationToken CancellationToken { get; }

        public CancellationTokenSource CancellationTokenSource { get; }

        public Task Task { get; }

        void Cancel();
    }
}