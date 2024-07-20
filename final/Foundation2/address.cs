namespace OnlineOrderingSystem
{
    public class _Address
    {
        private string _streetAddress;
        private string _city;
        private string _stateProvince;
        private string _country;

        public _Address(string streetAddress, string city, string stateProvince, string country)
        {
            this._streetAddress = streetAddress;
            this._city = city;
            this._stateProvince = stateProvince;
            this._country = country;
        }

        public bool IsInUSA()
        {
            return _country.ToLower() == "usa";
        }

        public override string ToString()
        {
            return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
        }
    }
}
