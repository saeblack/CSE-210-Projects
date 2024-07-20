namespace OnlineOrderingSystem
{
    public class Customer
    {
        private string _name;
        private _Address _address;

        public Customer(string _name, _Address _address)
        {
            this._name = _name;
            this._address = _address;
        }

        public bool IsInUSA()
        {
            return _address.IsInUSA();
        }

        public override string ToString()
        {
            return $"{_name}\n{_address}";
        }
    }
}
