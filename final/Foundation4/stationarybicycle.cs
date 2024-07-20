using System;

namespace ExerciseTrackingApp
{
    class _StationaryBicycles : _Activity
    {
        private int _speedKph;

        public _StationaryBicycles(DateTime date, int durationMinutes, int speedKph)
            : base(date, durationMinutes)
        {
            _speedKph = speedKph;
        }

        public override double GetDistance()
        {
            // Distance for stationary bicycles is not stored
            return 0;
        }

        public override double GetSpeed()
        {
            return _speedKph;
        }

        public override double GetPace()
        {
            // Pace for stationary bicycles is not applicable
            return 0;
        }

        protected override string _GetType()
        {
            return "Stationary Bicycles";
        }
    }
}
