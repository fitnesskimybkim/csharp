using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class RunArrayTest
    {
        static void Main(string[] args)
        {
            //Declare the array of two elements.
            int[][] arr = new int[2][];

            //init
            arr[0] = new int[5] {1,3,5,7,9};
            arr[1] = new int[4] { 2, 4, 6, 8 };

            //Display the array elements
            for(int i=0; i < arr.Length; i++)
            {
                System.Console.WriteLine("i / Element({0}):\n", i);
                for(int j=0; j < arr[i].Length; j++)
                {
                    System.Console.WriteLine("j / {0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
                }//for
                System.Console.WriteLine();
            }//for

            //Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
        }//Main
    }//class
}
