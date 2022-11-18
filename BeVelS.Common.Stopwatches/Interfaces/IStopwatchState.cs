namespace BeVelS.Common.Stopwatches.Interfaces
{
    public interface IStopwatchState
    {
        decimal GetStateAsdecimal();

        double GetStateAsdouble();

        float GetStateAsfloat();

        long GetStateAslong();

        void Reset();

        void Restart();

        void Start();

        void StartNew();

        void Stop();
    }
}