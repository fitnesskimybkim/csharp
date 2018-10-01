using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableTest
{
    class RunHashTable
    {
        static void Main(string[] args)
        {
            Hashtable onj = new Hashtable();

            onj.Add("김기동", "서울");
            onj.Add("홍길동", "광주");
            onj.Add("박길동", "부산");

            try
            {
                onj.Add("김기동", "서울");
            }
            catch
            {
                Console.WriteLine("키값 중복");
            }//try-catch

            Console.WriteLine("For Key = \"name\", value = {0}.", onj["홍길동"]);
            onj["박길동"] = "제주";

            if( !onj.ContainsKey("최길동"))
            {
                onj.Add("최길동", "하와이");
                Console.WriteLine("Value added for key = \"who\":{0}", onj["최길동"]);
            }//if

            Console.WriteLine();

            //print randomly.

            foreach(DictionaryEntry d in onj)
            {
                Console.WriteLine("Not Sorted1---Key = {0}, Value = {1}", d.Key, d.Value);
            }//foreach

            SortedList s = new SortedList(onj);

            foreach(DictionaryEntry d in s)
            {
                Console.WriteLine("Sorted---Key = {0}, Value = {1}", d.Key, d.Value);
            }//foreach

        }//Main
    }//class
}//NS
