using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class ReturnChangeState : IState
    {
        private readonly VendingMachine _vendingMachine;

        public ReturnChangeState(VendingMachine vendingMachine)
        {
            _vendingMachine = vendingMachine;
        }

        public void SelectProduct(Product product)
        {
            Console.WriteLine("Please collect the change first.");
        }

        public void InsertCoin(Coin coin)
        {
            Console.WriteLine("Please collect the change first.");
        }

        public void InsertNote(Note note)
        {
            Console.WriteLine("Please collect the change first.");
        }

        public void DispenseProduct()
        {
            Console.WriteLine("Product already dispensed. Please collect the change.");
        }

        public void ReturnChange()
        {
            double change = _vendingMachine.TotalPayment - _vendingMachine.SelectedProduct.Price;
            if (change > 0)
            {
                Console.WriteLine("Change returned: $" + change);
                _vendingMachine.ResetPayment();
            }
            else
            {
                Console.WriteLine("No change to return.");
            }
            _vendingMachine.ResetSelectedProduct();
            _vendingMachine.SetState(_vendingMachine.GetIdleState());
        }
    }
}
