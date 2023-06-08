using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Circle
    {
        public double radius;
        public string color;
        public double area;

        public Circle()
        {
            radius = 1;
            color = "blue";
        }

        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public String Color
        {
            get { return color; }
            set { color = value; }
        }

        public double Area
        {
            get { return area; }
            set { area = value; }
        }

        public double CalculArea()
        {
            area = Math.PI * radius * radius;
            return area;
        }

        public override string ToString()
        {
            return $"Radius: {radius}, Color: {color}, Area: {CalculArea()}";
        }
    }
}
