﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab3_GenericTest
{
    class Stack1<T>
    {
        int top = 0;
        T[] ar = new T[10];
        public void Push(T obj)
        {
            ar[top] = obj;
            top++;
        }
        public T Pop()
        {
            top--;
            return (dynamic)ar[top];
        }
    }

    class StackTest
    {
        static void Main()
        {
            Stack1<int> s1 = new Stack1<int>();
            s1.Push(1);
            s1.Push(2);
            s1.Push(3);
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());

            Stack1<string> s2 = new Stack1<string>();
            s2.Push("KOREA");
            s2.Push("대한민국");
            s2.Push("서울");
            Console.WriteLine(s2.Pop());
            Console.WriteLine(s2.Pop());
            Console.WriteLine(s2.Pop());
        }
    }
}
/*  
class Stack2
{
    int top = 0;
    string[] ar = new string[10];
    public void Push(string obj)
    {
        ar[top] = obj;
        top++;
    }
    public string Pop()
    {
        top--;
        return ar[top];
    }
}
*/
