namespace ExerciseTrackingApp
{
    class _Address
    {
        // Address properties and methods
        private string _streetAddress;
        private string _city;
        private string _stateProvince;
        private string _country;

        public _Address(string streetAddress, string city, string stateProvince, string country)
        {
            _streetAddress = streetAddress;
            _city = city;
            _stateProvince = stateProvince;
            _country = country;
        }

        public bool IsInUSA()
        {
            // Logic to determine if address is in USA
            return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return $"{_streetAddress}, {_city}, {_stateProvince}, {_country}";
        }
    }
}
