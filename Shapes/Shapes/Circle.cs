using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    public class Circle
    {
        double radius;
        public Circle()
        {
            radius = 0;
        }//Con1

        public Circle(double radius)
        {
            this.radius = radius;
        }//Con2

        public double Area()
        {
            return Math.PI * (radius * radius);
        }//Area
        public void Draw()
        {
            Pen p = new Pen(Color.Red);
        }
    }
}
