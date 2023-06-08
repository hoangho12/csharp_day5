using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point2D_and_Point3D
{
    class Point2D
    {
        public float x, y;

        public Point2D()
        {
            this.x = 0;
            this.y = 0;
        }
        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float GetX()
        {
            return this.x;
        }
        public float GetY()
        {
            return this.y;
        }
        public void SetX(float x)
        {
            this.x = x;
        }
        public void SetY(float y)
        {
            this.y = y;
        }
        public void SetXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float[] GetXY()
        {
            float[] array = { this.x, this.y };
            return array;
        }
        public override string ToString()
        {
            return $"({this.x},{this.y})";
        }
    }
}
