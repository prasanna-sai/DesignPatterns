/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace IteratorAndCompositePattern
{
    public interface IMenu
    {
        IEnumerable<MenuItem> CreateIterator();
    }
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }

    public class DinerMenu : IMenu
    {
        private int MAX_ITEMS = 6;
        private int currSize = 0;
        MenuItem[] items;

        public DinerMenu()
        {
            items = new MenuItem[MAX_ITEMS];
            AddItem("item1", "description1", 9.99);
            AddItem("item2", "description2", 1.3);
            AddItem("item3", "description3", 2.5);
            AddItem("item4", "description4", 2.78);
        }

        public void AddItem(string name, string description, double price)
        {
            var item = new MenuItem(name, description, price);
            if (currSize >= MAX_ITEMS)
            {
                Console.WriteLine("Menu is full, can't add more");
            }
            items[currSize++] = item;
        }

        public IEnumerable<MenuItem> CreateIterator()
        {
            return items.AsEnumerable();
        }
    }

    public class PanCakeMenu : IMenu
    {
        List<MenuItem> items;

        public PanCakeMenu()
        {
            items = new List<MenuItem>();
            AddItem("item5", "description5", 4.99);
            AddItem("item6", "description6", 9.3);
            AddItem("item7", "description7", 1.5);
            AddItem("item8", "description8", 7.78);
        }

        public IEnumerable<MenuItem> CreateIterator()
        {
            return items.AsEnumerable();
        }

        public void AddItem(string name, string description, double price)
        {
            var item = new MenuItem(name, description, price);
            items.Add(item);
        }
    }

    public class CafeMenu : IMenu
    {
        Dictionary<string, MenuItem> items;
        public CafeMenu()
        {
            items = new Dictionary<string, MenuItem>();
            AddItem("item9", "description5", 4.99);
            AddItem("item10", "description6", 9.3);
            AddItem("item11", "description7", 1.5);
            AddItem("item12", "description8", 7.78);
        }

        public IEnumerable<MenuItem> CreateIterator()
        {
            return items.Values.AsEnumerable();
        }

        public void AddItem(string name, string description, double price)
        {
            var item = new MenuItem(name, description, price);
            items.Add(name, item);
        }
    }

    public class Waitress
    {
        List<IMenu> menus;

        public Waitress(List<IMenu> menus)
        {
            this.menus = menus;
        }

        public void PrintMenu()
        {
            IEnumerable<IMenu> iterator = menus.AsEnumerable();
            foreach(var x in iterator)
            {
                PrintMenu(x.CreateIterator());
            }
        }

        public void PrintMenu(IEnumerable<MenuItem> iterator)
        {
            foreach (var item in iterator)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Name}, {item.Description}, {item.Price}");
                }
            }
        }
    }
}*/