namespace BeVelS.Common.Parallelism.Interfaces
{
    using BepuUtilities;
    using BeVelS.Common.Parallelism.Classes;

    public interface IParallelLooper
    {
        IThreadDispatcher Dispatcher { get; set; }

        void For(
            int start,
            int exclusiveEnd,
            LooperAction workAction,
            LooperWorkerDone workerDone = null);
    }
}