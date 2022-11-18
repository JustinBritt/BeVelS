namespace BeVelS.Common.Threading.Classes
{
    using BeVelS.Common.Threading.Interfaces;

    internal sealed class ThreadCount : IThreadCount
    {
        public ThreadCount(
            int value)
        {
            this.Value = value;
        }

        public int Value { get; }
    }
}