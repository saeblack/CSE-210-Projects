using System;

namespace ExerciseTrackingApp
{
    class _Swimming : _Activity
    {
        private int _laps;

        public _Swimming(DateTime date, int durationMinutes, int laps)
            : base(date, durationMinutes)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            // 50 meters per lap, converted to kilometers
            return _laps * 50 / 1000.0;
        }

        public override double GetSpeed()
        {
            return (GetDistance() / (double)_durationMinutes) * 60;
        }

        public override double GetPace()
        {
            return (double)_durationMinutes / GetDistance();
        }

        protected override string _GetType()
        {
            return "Swimming";
        }
    }
}
