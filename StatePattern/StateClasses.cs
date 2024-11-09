using System;
namespace StatePattern
{
    public interface IState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
    }

    public class GumballMachine
    {
        public NoQuarterState noQuarterState;
        public HasQuarterState hasQuarterState;
        public SoldState soldState;
        public SoldOutState soldOutState;
        public WinnerState winnerState;

        public IState state;
        public int count;

        public GumballMachine(int count)
        {
            this.count = count;
            this.noQuarterState = new NoQuarterState(this);
            this.soldState = new SoldState(this);
            this.hasQuarterState = new HasQuarterState(this);
            this.soldOutState = new SoldOutState(this);
            this.winnerState = new WinnerState(this);
            if(count > 0)
            {
                state = noQuarterState;
            }
            else
            {
                state = soldOutState;
            }
        }

        public void SetState(IState state)
        {
            this.state = state;
        }

        public void InsertQuarter()
        {
            state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            state.EjectQuarter();
        }

        public void TurnCrank()
        {
            state.TurnCrank();
            state.Dispense();
        }

        public void ReleaseGumBall()
        {
            if(count>0)
            {
                count--;
            }
        }
    }

    public class NoQuarterState : IState
    {
        GumballMachine gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Quarter is inserted");
            gumballMachine.SetState(gumballMachine.hasQuarterState);
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Nothing to eject, since the quarter is not inserted");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there is no quarter");
        }

        public void Dispense()
        {
            Console.WriteLine("You need to insert the quarter first");
        }
    }

    public class HasQuarterState : IState
    {
        Random rand = new Random();
        GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Quarter is already inserted");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned the crank");
            int winner = rand.Next(0,3);
            if (winner == 0)
            {
                gumballMachine.SetState(gumballMachine.winnerState);
            }
            else
            {
                gumballMachine.SetState(gumballMachine.soldState);
            }
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }

    public class SoldState : IState
    {
        GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Wait until the gumball is dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You can't turn crank twice for a single coin");
        }

        public void Dispense()
        {
            Console.WriteLine("Dispensing the gumball");
            gumballMachine.ReleaseGumBall();
            if(gumballMachine.count > 0)
            {
                gumballMachine.SetState(gumballMachine.noQuarterState);
            }
            else
            {
                gumballMachine.SetState(gumballMachine.soldOutState);
            }
        }
    }

    public class SoldOutState : IState
    {
        GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("No gumballs left, so you can't insert a quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
        }

        public void Dispense()
        {
            Console.WriteLine("No gumballs to dispense");
        }
    }

    public class WinnerState : IState
    {
        GumballMachine gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Wait until the gumball is dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You can't turn crank twice for a single gumball");
        }

        public void Dispense()
        {
            Console.WriteLine("Dispensing a gumball");
            gumballMachine.ReleaseGumBall();
            if (gumballMachine.count == 0)
            {
                gumballMachine.SetState(gumballMachine.soldOutState);
            }
            else
            {
                gumballMachine.ReleaseGumBall();
                Console.WriteLine("You are a winner");
                if (gumballMachine.count > 0)
                {
                    gumballMachine.SetState(gumballMachine.noQuarterState);
                }
                else
                {
                    gumballMachine.SetState(gumballMachine.soldOutState);
                }
            }
        }
    }
}