using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Eagle : Duck
{
    public Eagle()
    {
        quackBehavior = new Screech();
        flyBehavior = new Soar();
    }
    public override void Display()
    {
        Console.WriteLine("I'm a rubber duck");
        Console.WriteLine("Fred is confused");
    }

}