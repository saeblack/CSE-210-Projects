using System;

namespace ExerciseTrackingApp
{
    abstract class _Event
    {
        protected string _title;
        protected string _description;
        protected DateTime _date;
        protected string _time;
        protected _Address _address;

        public _Event(string title, string description, DateTime date, string time, _Address address)
        {
            _title = title;
            _description = description;
            _date = date;
            _time = time;
            _address = address;
        }

        public virtual string GetStandardDetails()
        {
            return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address}";
        }

        public virtual string GetFullDetails()
        {
            return $"Standard Details:\n{GetStandardDetails()}\nEvent Type: {_GetTypeSpecificDetails()}";
        }

        public abstract string GetShortDescription();

        protected abstract string _GetTypeSpecificDetails();
    }
}
