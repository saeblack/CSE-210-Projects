using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineOrderingSystem
{
    public class _Order
    {
        private List<Product> _products;
        private Customer _customer;

        public _Order(Customer _customer)
        {
            this._customer = _customer;
            _products = new List<Product>();
        }

        public void AddProduct(Product _product)
        {
            _products.Add(_product);
        }

        public decimal GetTotalCost()
        {
            decimal _totalCost = 0;
            foreach (var _product in _products)
            {
                _totalCost += _product.GetTotalCost();
            }

            _totalCost += _customer.IsInUSA() ? 5 : 35;
            return _totalCost;
        }

        public string GetPackingLabel()
        {
            StringBuilder _packingLabel = new StringBuilder();
            foreach (var _product in _products)
            {
                _packingLabel.AppendLine(_product.ToString());
            }
            return _packingLabel.ToString();
        }

        public string GetShippingLabel()
        {
            return _customer.ToString();
        }
    }
}
