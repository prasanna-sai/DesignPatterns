using System;
namespace Ducks
{
    public interface IFlyableBehavior
    {
        void Fly();
    }

    public interface IQuackableBehavior
    {
        void Quack();
    }

    public class FlyWithWings : IFlyableBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Fly with wings");
        }
    }

    public class FlyNoWay : IFlyableBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Can't fly");
        }
    }

    public class Quacks : IQuackableBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Can Quack");
        }
    }

    public class Squeak : IQuackableBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Can squeak");
        }
    }

    public class MuteQuack : IQuackableBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Can't Quack");
        }
    }
    public class Duck
    {

        public IFlyableBehavior flyableBehavior;

        public IQuackableBehavior quackableBehavior;

        public void Swim()
        {

        }

        public virtual void Display()
        {

        }

        public void SetFlyableBehavior(IFlyableBehavior flyableBehavior)
        {
            this.flyableBehavior = flyableBehavior;
        }

        public void SetQuackableBehavior(IQuackableBehavior quackableBehavior)
        {
            this.quackableBehavior = quackableBehavior;
        }

    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.quackableBehavior = new MuteQuack();
            this.flyableBehavior = new FlyNoWay();
        }
        public void Quack()
        {
            
        }

        public override void Display()
        {
        
        }

    }

    public class ReaHeadDuck : Duck
    {
        public void Quack()
        {

        }

        public override void Display()
        {

        }

        public void Fly()
        {

        }
    }

    public class RubberDuck : Duck
    {
        public void Quack()
        {

        }

        public override void Display()
        {

        }

    }

    public class WoodenDuck : Duck
    {
        public void Quack()
        {

        }

        public override void Display()
        {

        }
    }
}