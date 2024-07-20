using System;

namespace ExerciseTrackingApp
{
    class _Reception : _Event
    {
        private string _rsvpEmail;

        public _Reception(string title, string description, DateTime date, string time, _Address address, string rsvpEmail)
            : base(title, description, date, time, address)
        {
            _rsvpEmail = rsvpEmail;
        }

        public override string GetShortDescription()
        {
            return $"Reception: {_title}, Date: {_date.ToShortDateString()}";
        }

        protected override string _GetTypeSpecificDetails()
        {
            return $"RSVP Email: {_rsvpEmail}";
        }
    }
}

