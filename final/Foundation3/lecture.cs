using System;

namespace ExerciseTrackingApp
{
    class _Lecture : _Event
    {
        private string _speaker;
        private int _capacity;

        public _Lecture(string title, string description, DateTime date, string time, _Address address, string speaker, int capacity)
            : base(title, description, date, time, address)
        {
            _speaker = speaker;
            _capacity = capacity;
        }

        public override string GetShortDescription()
        {
            return $"Lecture: {_title}, Date: {_date.ToShortDateString()}";
        }

        protected override string _GetTypeSpecificDetails()
        {
            return $"Speaker: {_speaker}, Capacity: {_capacity}";
        }
    }
}

