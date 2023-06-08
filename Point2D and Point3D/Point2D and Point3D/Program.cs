using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point2D_and_Point3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D p2D = new Point2D();
            p2D.SetX(5);
            p2D.SetY(10);
            Console.WriteLine(p2D.ToString());

            Console.WriteLine();

            Point3D p3D = new Point3D(3, 6, 4);
            Console.WriteLine(p3D.ToString());

            Console.ReadKey();
        }
    }
}
