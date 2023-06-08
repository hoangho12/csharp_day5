using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cylinder: Circle
    {
        private double height;
        private double volume;

        public Cylinder()
        {
            height = 1;
        }

        public Cylinder(double radius, double height, string color) : base(radius, color)
        {
            this.height = height;
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double CalculVolume()
        {
            volume = Math.PI * radius * radius * height;
            return volume;
        }

        public double CalculArea()
        {
            area = 2 * Math.PI * radius * (radius + height);
            return area;
        }

        public override string ToString()
        {
            return $"Radius: {radius}, Color: {color}, Height: {height}, Area: {CalculArea()}, Volume: {CalculVolume()}";
        }
    }
}
