using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5.0, "Blue");
            
            Cylinder cylinder = new Cylinder(3.0, 8.0, "White");

            Console.WriteLine(circle.ToString());
            Console.WriteLine(cylinder.ToString());

            Console.ReadKey();
        }
    }
}
