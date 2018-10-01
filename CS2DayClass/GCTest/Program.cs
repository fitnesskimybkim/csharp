using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCTest
{
    class Garbage : IDisposable
    {
        private bool isDispose = false;
        private string name;

        public Garbage(string name)
        {
            this.name = name;
            Console.WriteLine("{0} 객체가 생성됨!!", this.name);
        }//Con

        ~Garbage()
        {
            if( !isDispose )
            {
                Dispose();
            }//if
        }//~Garbage
        public void Dispose()
        {
            isDispose = true;

            //Release resource
            Console.WriteLine("{0} 객체의 리소스를 해제 OK !!", name);
            GC.SuppressFinalize(this);
        }//Dispose()
    }//GC

    class RunGCTest
    {

        static void Main(string[] args)
        {
            Garbage g1 = new Garbage("1번객체"); Garbage g2 = new Garbage("2번객체");
            Garbage g3 = new Garbage("3번객체"); Garbage g4 = new Garbage("4번객체");
            g1.Dispose();
            GC.SuppressFinalize(g2);        }//Main
    }//Class
}
