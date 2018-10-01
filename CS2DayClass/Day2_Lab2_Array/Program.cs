using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Lab2_Array
{
    class Program
    {

//[결과]
//12345678
//12345678

        static void Main(string[] args)
        {
            //----4행2열
            int[,] twoDim = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            for (int i = 0; i < twoDim.GetLength(0); i++ )
            {
                for (int j = 0; j < twoDim.GetLength(1); j++ )
                {
                    Console.Write(twoDim[i, j]);
                }
            }
            Console.WriteLine();
            foreach (int i in twoDim )
            {
                Console.Write(i);   
            }
        }
    }
}
