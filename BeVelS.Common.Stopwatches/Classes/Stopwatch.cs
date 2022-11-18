namespace BeVelS.Common.Stopwatches.Classes
{
    using System.Runtime.InteropServices;
    using System.Threading.Tasks;

    internal sealed class Stopwatch
    {
        public Stopwatch()
        {
            this.ElapsedTicks = 0;
        }

        public static long Frequency => QueryPerformanceFrequency();

        public long ElapsedTicks { get; private set; }

        private bool IsRunning { get; set; }

        private long StartingTimestamp { get; set; }

        [DllImport("kernel32", SetLastError = true)]
        private static extern bool QueryPerformanceCounter(
            out long lpPerformanceCount);

        [DllImport("kernel32", SetLastError = true)]
        private static extern bool QueryPerformanceFrequency(
            out long frequency);

        private long CalculateElapsedTicks()
        {
            return GetTimestamp() - this.StartingTimestamp;
        }

        private static Stopwatch Create()
        {
            return new Stopwatch();
        }

        public static long GetTimestamp()
        {
            return QueryPerformanceCounter();
        }

        private static long QueryPerformanceCounter()
        {
            long lpPerformanceCount;

            QueryPerformanceCounter(
                out lpPerformanceCount);

            return lpPerformanceCount;
        }

        private static long QueryPerformanceFrequency()
        {
            long frequency;

            QueryPerformanceFrequency(
                out frequency);

            return frequency;
        }

        public void Reset()
        {
            this.IsRunning = false;

            this.ElapsedTicks = 0;
        }

        public void Restart()
        {
            this.Reset();
            
            this.Start();
        }

        private void Run()
        {
            this.IsRunning = true;

            Task.Run(
                () =>
                {
                    while (this.IsRunning)
                    {
                        this.UpdateElapsedTicks();
                    }
                });
        }

        public void Start()
        {
            this.StartingTimestamp = QueryPerformanceCounter();

            this.Run();
        }

        public static Stopwatch StartNew()
        {
            Stopwatch stopwatch = Create();

            stopwatch.Start();

            return stopwatch;
        }

        public void Stop()
        {
            this.IsRunning = false;
        }

        private void UpdateElapsedTicks()
        {
            this.ElapsedTicks = this.CalculateElapsedTicks();
        }
    }
}