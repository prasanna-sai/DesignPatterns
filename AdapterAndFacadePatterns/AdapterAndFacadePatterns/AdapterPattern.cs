using System;
namespace AdapterPattern
{
    public interface IDuck
    {
        void Fly();
        void Quack();
    }

    public class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("Mallard Duck is flying");
        }

        public void Quack()
        {
            Console.WriteLine("Mallard Duck is Quacking");
        }
    }

    public interface ITurkey
    {
        void Gobble();
        void Fly();
    }

    public class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gobble, Gobble");
        }

        public void Fly()
        {
            Console.WriteLine("Small distance flying");
        }
    }

    public class TurkeyAdapter : IDuck
    {
        public ITurkey turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        public void Fly()
        {
            turkey.Fly();
        }

        public void Quack()
        {
            turkey.Gobble();
        }
    }
}