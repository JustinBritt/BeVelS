namespace BeVelS.Common.Stopwatches.Classes
{
    using BeVelS.Common.Stopwatches.Interfaces;

    internal sealed class StopwatchState : IStopwatchState
    {
        public StopwatchState()
        {
            this.Frequency = Stopwatch.Frequency;
        }

        private long Frequency { get; }

        private long PreviousTimestamp { get; set; }

        private Stopwatch Stopwatch { get; set; }

        private long CalculateDifference(
            long previousTimestamp,
            long timestamp)
        {
            return timestamp - previousTimestamp;
        }

        private decimal CalculateStateAsdecimal(
            long frequency,
            long previousTimestamp,
            long timestamp)
        {
            return this.CalculateDifference(
                previousTimestamp: previousTimestamp,
                timestamp: timestamp)
                /
                (decimal)frequency;
        }

        private double CalculateStateAsdouble(
            long frequency,
            long previousTimestamp,
            long timestamp)
        {
            return this.CalculateDifference(
                previousTimestamp: previousTimestamp,
                timestamp: timestamp)
                /
                (double)frequency;
        }

        private float CalculateStateAsfloat(
            long frequency,
            long previousTimestamp,
            long timestamp)
        {
            return this.CalculateDifference(
                previousTimestamp: previousTimestamp,
                timestamp: timestamp) 
                / 
                (float)frequency;
        }

        private long CalculateStateAslong(
            long frequency,
            long previousTimestamp,
            long timestamp)
        {
            return (long)this.CalculateStateAsdouble(
                frequency: frequency,
                previousTimestamp: previousTimestamp,
                timestamp: timestamp);
        }

        public decimal GetStateAsdecimal()
        {
            long timestamp = Stopwatch.GetTimestamp();

            decimal state = this.CalculateStateAsdecimal(
                frequency: this.Frequency,
                previousTimestamp: this.PreviousTimestamp,
                timestamp: timestamp);

            this.PreviousTimestamp = timestamp;

            return state;
        }

        public double GetStateAsdouble()
        {
            long timestamp = Stopwatch.GetTimestamp();

            double state = this.CalculateStateAsdouble(
                frequency: this.Frequency,
                previousTimestamp: this.PreviousTimestamp,
                timestamp: timestamp);

            this.PreviousTimestamp = timestamp;

            return state;
        }

        public float GetStateAsfloat()
        {
            long timestamp = Stopwatch.GetTimestamp();

            float state = this.CalculateStateAsfloat(
                frequency: this.Frequency,
                previousTimestamp: this.PreviousTimestamp,
                timestamp: timestamp);

            this.PreviousTimestamp = timestamp;

            return state;
        }

        public long GetStateAslong()
        {
            long timestamp = Stopwatch.GetTimestamp();

            long state = this.CalculateStateAslong(
                frequency: this.Frequency,
                previousTimestamp: this.PreviousTimestamp,
                timestamp: timestamp);

            this.PreviousTimestamp = timestamp;

            return state;
        }

        public void Reset()
        {
            this.Stopwatch.Reset();
        }

        public void Restart()
        {
            this.Stopwatch.Restart();
        }

        public void Start()
        {
            this.Stopwatch.Start();
        }

        public void StartNew()
        {
            this.Stopwatch = Stopwatch.StartNew();

            this.PreviousTimestamp = Stopwatch.GetTimestamp();
        }

        public void Stop()
        {
            this.Stopwatch.Stop();
        }
    }
}