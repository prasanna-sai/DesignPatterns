using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodPattern;

namespace TemplateMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tea = new Tea();
            tea.PrepareRecipe();
            var coffee = new Coffee();
            coffee.PrepareRecipe();
        }
    }
}
