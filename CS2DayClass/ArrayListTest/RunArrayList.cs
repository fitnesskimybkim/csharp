using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListTest
{
    class RunArrayList
    {
        static void Main(string[] args)
        {
            ArrayList onj = new ArrayList();
            //List<string> onj = new List<string>();

            onj.Add("Onj");
            onj.Add("OracleJava");
            onj.Add("Communitiy");
            onj.Add(123);
            onj.Add(new RunArrayList());

            Console.WriteLine("onj List");
            Console.WriteLine("---------Count : {0}", onj.Count);
            Console.WriteLine("---------Capacity : {0}", onj.Capacity);
            Console.Write("Onj Values:");

            PrintValues(onj);

            ArrayList onj2 = (ArrayList)onj.Clone();
            Console.Write("onj2 values:");
            PrintValues(onj2);
        }

        public static void PrintValues(IEnumerable myList)
        {
            foreach( Object obj in myList )
            {
                Console.Write("----{0}----", obj);
            }//foreach
            Console.WriteLine();
        }//PrintValues
    }
}
