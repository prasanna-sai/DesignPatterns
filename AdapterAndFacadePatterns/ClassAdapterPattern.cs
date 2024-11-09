//This is class adapter, but we have to do with multiple inheritence

using System;
namespace AdapterPattern
{
    public class Duck
    {
        public virtual void Fly()
        {

        }
        public virtual void Quack()
        {

        }
    }

    public class MallardDuckClass : Duck
    {

        public override void Quack()
        {
            Console.WriteLine("Mallard Duck is Not Quacking");
        }
    }

    public class Turkey
    {
        public virtual void Gobble()
        {
            Console.WriteLine("Gobble Gobble");
        }
        public virtual void Fly()
        {
            Console.WriteLine("Small flight");
        }
    }

    public class WildTurkeyClass : Turkey
    {
        public override void Gobble()
        {
            Console.WriteLine("Wild Gobble");
        }
    }

    public class TurkeyAdapterClass : Duck
    {
        public ITurkey turkey;
    }
}