using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point2D_and_Point3D
{
    class Point3D : Point2D
    {
        float z;

        public Point3D() : base()
        {
            z = 0;
        }
        public Point3D(float x, float y, float z) : base(x, y)
        {
            this.z = z;
        }
        public float GetZ()
        {
            return z;
        }
        public void SetZ(float z)
        {
            this.z = z;
        }
        public void SetXYZ(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public float[] GetXYZ()
        {
            float[] array = { x, y, this.z };
            return array;
        }
        public override string ToString()
        {
            return $"({x}, {y}, {this.z})";
        }
    }
}
