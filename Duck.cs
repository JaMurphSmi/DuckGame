using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Duck
{
    protected IFlyBehavior flyBehavior;
    protected IQuackBehavior quackBehavior;
    public IQuackBehavior QuackBehavior
    { //this is a C# property
        get { return quackBehavior; }
        set { quackBehavior = value; }
    }
    public IFlyBehavior FlyBehavoir
    { //this is a C# property
        get { return flyBehavior; }
        set { flyBehavior = value; }
    }
    public abstract void Display();
    public void PerformFly() { FlyBehavoir.Fly(); }
    public void PerformQuack() { QuackBehavior.Quacking(); }
    public void Swim() { Console.WriteLine("All ducks float, even decoys!"); }
}
