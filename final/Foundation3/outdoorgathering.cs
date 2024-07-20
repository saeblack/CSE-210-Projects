using System;

namespace ExerciseTrackingApp
{
    class _OutdoorGathering : _Event
    {
        private string _weatherForecast;

        public _OutdoorGathering(string title, string description, DateTime date, string time, _Address address, string weatherForecast)
            : base(title, description, date, time, address)
        {
            _weatherForecast = weatherForecast;
        }

        public override string GetShortDescription()
        {
            return $"Outdoor Gathering: {_title}, Date: {_date.ToShortDateString()}";
        }

        protected override string _GetTypeSpecificDetails()
        {
            return $"Weather Forecast: {_weatherForecast}";
        }
    }
}

