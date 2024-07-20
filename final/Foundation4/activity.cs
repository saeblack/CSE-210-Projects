using System;

namespace ExerciseTrackingApp
{
    abstract class _Activity
    {
        protected DateTime _date;
        protected int _durationMinutes;

        public _Activity(DateTime date, int durationMinutes)
        {
            _date = date;
            _durationMinutes = durationMinutes;
        }

        public abstract double GetDistance();

        public abstract double GetSpeed();

        public abstract double GetPace();

        public virtual string GetSummary()
        {
            return $"{_date.ToString("dd MMM yyyy")} {_GetType()} ({_durationMinutes} min): Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
        }

        protected abstract string _GetType();
    }
}
