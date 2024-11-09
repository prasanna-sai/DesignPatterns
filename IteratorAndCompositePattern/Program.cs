using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndCompositePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*var waitress = new Waitress(new PanCakeMenu(), new DinerMenu(), new CafeMenu());
            waitress.PrintMenu();*/

            /*var waitress = new Waitress(new List<IMenu>() { new PanCakeMenu(), new DinerMenu(), new CafeMenu()});
            waitress.PrintMenu();*/

            MenuComponent PanHouseMenu = new Menu("PanCake House Menu");
            MenuComponent DinerMenu = new Menu("Diner Menu");
            MenuComponent CafeMenu = new Menu("Cafe Menu");
            MenuComponent DessertMenu = new Menu("Dessert Menu");

            MenuComponent AllMenus = new Menu("All Menus");

            AllMenus.AddItem(PanHouseMenu);
            AllMenus.AddItem(DinerMenu);
            AllMenus.AddItem(CafeMenu);
            DinerMenu.AddItem(new MenuItem("Item1", "Item1 Description", 1.99));
            DinerMenu.AddItem(DessertMenu);
            DessertMenu.AddItem(new MenuItem("DessertItem1", "desc", 1.09));
            var waitress = new Waitress(AllMenus);
            waitress.PrintMenu();

        }
    }
}
