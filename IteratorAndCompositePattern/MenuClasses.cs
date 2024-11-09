/*using System;
using System.Collections.Generic;

namespace IteratorAndCompositePattern
{
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

    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }

    public class DinerMenuIterator<T> : IIterator<T> 
    {
        private T[] items;
        private int Position = 0;

        public DinerMenuIterator(T[] items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            if(Position >= items.Length || items[Position] == null)
            {
                return false;
            }
            return true;
        }

        public T Next()
        {
            return items[Position++];
        }
    }

    public class PanCakeMenuIterator<T> : IIterator<T>
    {
        private List<T> items;
        private int Position = 0;

        public PanCakeMenuIterator(List<T> items)
        {
            this.items = items;
        }
        public bool HasNext()
        {
            if (Position >= items.Count)
            {
                return false;
            }
            return true;
        }

        public T Next()
        {
            return items[Position++];
        }
    }

    public class DinerMenu
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
            if(currSize >= MAX_ITEMS)
            {
                Console.WriteLine("Menu is full, can't add more");
            }
            items[currSize++] = item;
        }

        public IIterator<MenuItem> CreateIterator()
        {
            return new DinerMenuIterator<MenuItem>(items);
        }
    }

    public class PanCakeMenu
    {
        List<MenuItem> items;

        public PanCakeMenu()
        {
            items=new List<MenuItem>();
            AddItem("item5", "description5", 4.99);
            AddItem("item6", "description6", 9.3);
            AddItem("item7", "description7", 1.5);
            AddItem("item8", "description8", 7.78);
        }

        public IIterator<MenuItem> CreateIterator()
        {
            return new PanCakeMenuIterator<MenuItem>(items);
        }

        public void AddItem(string name, string description, double price)
        {
            var item = new MenuItem(name, description, price);
            items.Add(item);
        }
    }

    public class Waitress
    {
        PanCakeMenu panCakeMenu;
        DinerMenu dinerMenu;

        public Waitress(PanCakeMenu panCakeMenu, DinerMenu dinerMenu)
        {
            this.panCakeMenu = panCakeMenu;
            this.dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            var pancakeIterator = panCakeMenu.CreateIterator();
            var dinerIterator = dinerMenu.CreateIterator();
            Console.WriteLine("Breakfast menu is");
            PrintMenu(pancakeIterator);
            Console.WriteLine("Lunch Menu is");
            PrintMenu(dinerIterator);
        }

        public void PrintMenu(IIterator<MenuItem> iterator)
        {
            while(iterator.HasNext())
            {
                var item = iterator.Next();
                Console.WriteLine($"{item.Name}, {item.Description}, {item.Price}");
            }
        }
    }
}*/