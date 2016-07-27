using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Bacis inheritance *****");
            // Make a car object and set max speed
            Car myCar = new Car(80);

            // Set the current speed and print it out.
            myCar.Speed = 50;
            Console.WriteLine("My car is going {0} MPH", myCar.Speed);
            Console.ReadLine();

            // Now make use of the minivan class
            MiniVan myVan = new MiniVan();
            myVan.Speed = 10;
            Console.WriteLine("My minivan is going {0} MPH", myVan.Speed);
            Console.ReadLine();
        }
    }
}
