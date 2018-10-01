using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace ShapesUser
{
    class RunShapesUser
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(1.0F);
            Console.WriteLine("Aread of Circle(1.0) is {0}", c.Area() );
        }
    }
}
