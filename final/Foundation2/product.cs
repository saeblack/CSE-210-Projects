namespace OnlineOrderingSystem
{
    public class Product
    {
        private string _name;
        private string _productId;
        private decimal _pricePerUnit;
        private int _quantity;

        public Product(string name, string productId, decimal pricePerUnit, int quantity)
        {
            this._name = name;
            this._productId = productId;
            this._pricePerUnit = pricePerUnit;
            this._quantity = quantity;
        }

        public decimal GetTotalCost()
        {
            return _pricePerUnit * _quantity;
        }

        public override string ToString()
        {
            return $"{_name} (ID: {_productId})";
        }
    }
}
