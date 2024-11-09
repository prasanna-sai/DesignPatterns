using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine
{
    public class Payment
    {
        public double Amount { get; }
        public Payment(double amount)
        {
            Amount = amount;
        }
    }
}
