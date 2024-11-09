using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Inventory
    {
        private ConcurrentDictionary<Product, int> _products;

        public Inventory()
        {
            _products = new ConcurrentDictionary<Product, int>();
        }

        public void AddProduct(Product product, int quantity)
        {
            _products[product] = quantity;
        }

        public int GetQuantity(Product product)
        {
            _products.TryGetValue(product, out int quantity);
            return quantity;
        }

        public void UpdateQuantity(Product product, int quantity)
        {
            _products[product] = quantity;
        }

        public bool IsAvailable(Product product)
        {
            return _products.ContainsKey(product) && _products[product] > 0;
        }
    }
}
