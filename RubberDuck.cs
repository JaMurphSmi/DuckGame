using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RubberDuck : Duck
{
    public RubberDuck()
    {
        quackBehavior = new Squeak();
        flyBehavior = new FlyNoWay();
    }
    public override void Display()
    {
        Console.WriteLine("I'm a rubber duck");
    }
}

