using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine
{
    public class Ingredient
    {
        public string Name { get; }
        private int quantity;
        public Ingredient(string name, int quantity)
        {
            Name = name;
            this.quantity = quantity;
        }

        public int Quantity
        {
            get { return quantity; }
        }

        public void UpdateQuantity(int amount)
        {
            quantity += amount;
        }
    }
}
