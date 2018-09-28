using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_varTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            short a = 10;
            int b = a;
            int c = 50000;
            var bb = 9.0000000000000000001;
            short d = 0;
            int aa;
            try
            {
                d = (short)b;
                short e = checked((short)c);
            }
            catch ( Exception e)
            {
                Console.WriteLine("Exception!! {0}", e.StackTrace);
            }
            Console.WriteLine("Short : {0}", d);
        }
    }
}
