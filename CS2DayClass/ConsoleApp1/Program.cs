using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapValueRef
{
    class Program
    {
        static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }//Swap

        static void Swap_ref(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }//Swap

        static void Swap_out(out int aOut, out int bOut)
        {
            int a = 100;
            int b = 100;

            aOut = a;
            bOut = b;
        }//Swap

        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            int cOut;  //should not be inited
            int dOut;  //should not be inited

            Console.WriteLine("Bf: a={0}, b={1}", a, b);
            Swap(a, b);
            Console.WriteLine("Af: a={0}, b={1}", a, b);

            Console.WriteLine("Bf_ref: a={0}, b={1}", a, b);
            Swap_ref(ref a, ref b);
            Console.WriteLine("Af_ref: a={0}, b={1}", a, b);

            Console.WriteLine("Bf_out: a={0}, b={1}", a, b);
            Swap_out(out cOut, out dOut);
            Console.WriteLine("Af_out: c={0}, d={1}", cOut, dOut);

        }//Main

    }
}
