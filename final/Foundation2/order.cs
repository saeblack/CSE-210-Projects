namespace OnlineOrderingSystem
{
    public class _Order
    {
        private Customer _customer;
        private List<Product> _products;
        private string _packingLabel;
        private string _shippingLabel;

        public _Order(Customer customer)
        {
            this._customer = customer;
            this._products = new List<Product>();
            this._packingLabel = GenerateUniqueLabel("P");
            this._shippingLabel = GenerateUniqueLabel("S");
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal GetTotalCost()
        {
            return _products.Sum(product => product.GetTotalCost());
        }

        public string GetPackingLabel()
        {
            return _packingLabel;
        }

        public string GetShippingLabel()
        {
            return _shippingLabel;
        }

        private string GenerateUniqueLabel(string prefix)
        {
            return $"{prefix}-{Guid.NewGuid().ToString()}";
        }
    }
}
