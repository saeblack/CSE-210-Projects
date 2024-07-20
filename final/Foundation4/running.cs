using System;

namespace ExerciseTrackingApp
{
    class _Running : _Activity
    {
        private double _distanceKm;

        public _Running(DateTime date, int durationMinutes, double distanceKm)
            : base(date, durationMinutes)
        {
            _distanceKm = distanceKm;
        }

        public override double GetDistance()
        {
            return _distanceKm;
        }

        public override double GetSpeed()
        {
            return (_distanceKm / (double)_durationMinutes) * 60;
        }

        public override double GetPace()
        {
            return (double)_durationMinutes / _distanceKm;
        }

        protected override string _GetType()
        {
            return "Running";
        }
    }
}
