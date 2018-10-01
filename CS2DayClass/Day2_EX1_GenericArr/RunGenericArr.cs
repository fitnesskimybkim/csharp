using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_EX1_GenericArr
{

        class MyArray<T>
        {
            private T[] onj;
            public MyArray(int size)
            {
                onj = new T[size];
            }//con

            public void SetElement(int index, T value)
            {
                onj[index] = value;
            }//SetElement()

            public T GetElement(int index, T value)
            {
                return onj[index];
            }//GetElement

            public void PrintElements()
            {
                foreach( T o in onj)
                {
                    Console.WriteLine(o);
                }//foreach
            }//PrintElements
        }//class MyArray<T>


    class RunGenericArr
    {
        static void Main(string[] args)
        {
            //int 형을 매개 변수로 MyArray<T>의 객체를 생성.
            MyArray<string> array = new MyArray<string>(4);
            array.SetElement(0, "OnjOracleJava");
            array.SetElement(1, "OracleJava Commmunity");
           
            array.SetElement(2, "onjprogramming.co.kr");
            array.SetElement(3,"oraclejavanew.kr");
            array.PrintElements();        }
    }
}
