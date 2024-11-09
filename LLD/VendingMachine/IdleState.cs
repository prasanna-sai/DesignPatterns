using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class IdleState : IState
    {
        private readonly VendingMachine _vendingMachine;

        public IdleState(VendingMachine vendingMachine)
        {
            _vendingMachine = vendingMachine;
        }

        public void SelectProduct(Product product)
        {
            if (_vendingMachine.Inventory.IsAvailable(product))
            {
                _vendingMachine.SetSelectedProduct(product);
                _vendingMachine.SetState(_vendingMachine.GetReadyState());
                Console.WriteLine("Product selected: " + product.Name);
            }
            else
            {
                Console.WriteLine("Product not available: " + product.Name);
            }
        }

        public void InsertCoin(Coin coin)
        {
            Console.WriteLine("Please select a product first.");
        }

        public void InsertNote(Note note)
        {
            Console.WriteLine("Please select a product first.");
        }

        public void DispenseProduct()
        {
            Console.WriteLine("Please select a product and make payment.");
        }

        public void ReturnChange()
        {
            Console.WriteLine("No change to return.");
        }
    }
}
