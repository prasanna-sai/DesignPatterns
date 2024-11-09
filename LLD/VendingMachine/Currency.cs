using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public enum Coin
    {
        Penny = 1,
        Nickel = 5,
        Dime = 10,
        Quarter = 25
    }

    public enum Note
    {
        One = 1,
        Five = 5,
        Ten = 10,
        Twenty = 20
    }

    public static class CoinExtensions
    {
        public static double GetValue(this Coin coin)
        {
            return (int)coin/100.0;
        }
    }

    public static class NoteExtensions
    {
        public static double GetValue(this Note note)
        {
            return (int)note;
        }
    }
}
