using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Main Demo class
class MainDucks
{
    static void Main()
    {
        Duck RubberDuck = new RubberDuck();
        RubberDuck.PerformFly();
        RubberDuck.PerformQuack();
        RubberDuck.Display();
        Duck FredTheEagle = new Eagle();
        FredTheEagle.PerformFly();
        FredTheEagle.PerformQuack();
        FredTheEagle.Display();

        Console.ReadKey();
    }
}

