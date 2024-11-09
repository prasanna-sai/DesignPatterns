using System;
using System.Collections.Generic;
using static IteratorAndCompositePattern.MenuItem;
using System.Linq;

namespace IteratorAndCompositePattern
{
    public class MenuComponent
    {
        public virtual void AddItem(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual MenuComponent GetChild(int index)
        {
            throw new NotSupportedException();
        }

        public virtual void Print()
        {
            throw new NotSupportedException();
        }
    }

    public class MenuItem : MenuComponent
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

        public override void Print()
        {
            Console.WriteLine($"Name - {this.Name}, Description - {this.Description}, Price - {this.Price}");
        }
    }

    public class Menu : MenuComponent
    {
        public List<MenuComponent> items;

        public string Name { get; set; }

        public Menu(string Name) : base()
        {
            this.Name = Name;
            items = new List<MenuComponent>();
        }

        public override void AddItem(MenuComponent menuComponent)
        {
            items.Add(menuComponent);
        }

        public override MenuComponent GetChild(int index)
        {
            return items[index];
        }

        public override void Print()
        {
            Console.WriteLine($"Menu is of {this.Name}");
            foreach(var item in items)
            {
                item.Print();
            }
        }
    }

    public class Waitress
    {
        MenuComponent allMenus;

        public Waitress(MenuComponent menus)
        {
            this.allMenus = menus;
        }

        public void PrintMenu()
        {
            allMenus.Print();
        }
    }
}