using Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//C# singleton - https://chatgpt.com/share/4e7eaf01-187a-4628-b6b1-9e6f171dae70
namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var instance = SingletonEagerInstantiation.GetInstance();
        }
    }
}
