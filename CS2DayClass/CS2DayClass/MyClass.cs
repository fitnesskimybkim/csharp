using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2DayClass
{
    class MyBaseClass
    {
        public MyBaseClass()
        {
            Console.WriteLine(">>> Con0-MyBaseClass()");
        }//con0

        public MyBaseClass(int i)
        {
            Console.WriteLine(">>> Con1-MyBaseClass()");
        }//con1
    }//MyBaseClass

    class MyClass : MyBaseClass
    {
        public MyClass()
        {
            Console.WriteLine(">>>Con0-MyClass()");
        }//Con0

        public MyClass(int i) : base(i)
        {
            Console.WriteLine(">>>Con1B-MyClass(int i)");
        }//Con1

        public MyClass(int i, int j)
        {
            Console.WriteLine(">>>Con2-MyClass(int i, int j)");
        }//Con0

        public MyClass(int i, int j, int k) : base(i)
        {
            Console.WriteLine(">>>Con3B-MyClass(int i, int j, int k)");
        }//Con0

        static void Main(string[] args)
        {
        }
    }
}
