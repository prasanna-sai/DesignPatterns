using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRUCache
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cache = new LRUCache<int, string>(3);
            cache.Put(1, "1");
            cache.Put(2, "2");
            cache.Put(3, "3");

            Console.WriteLine(cache.Get(1));
            Console.WriteLine(cache.Get(2));

            cache.Put(4, "4");

            Console.WriteLine(cache.Get(3));
            Console.WriteLine(cache.Get(4));

            cache.Put(2, "2.0");
            Console.WriteLine(cache.Get(2));
            Console.WriteLine(cache.Get(1));
        }
    }
}
