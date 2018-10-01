using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    public abstract class Dog
    {
        public string name { get; set; }
        public void jitda()
        {
            Console.WriteLine(name + "가 짖다");
        }//jitda()

        public virtual void jitda_vir()
        {
            Console.WriteLine("[Parent-Virtual] " + name + "가 짖다");
        }//jitda()

        public abstract void jitda_abs();
    }//Dog


    public class Pudle : Dog
    {
        public void work()
        {
            Console.WriteLine("Pudle : " + name + " 가 짖는다");
        }//work

        public override void jitda_vir()
        {
            Console.WriteLine("[Puddle:Vir/Override] " + name + "가 짖다");
        }//jitda_vir()

        public override void jitda_abs()
        {
            Console.WriteLine("[Pdl:ABS/Override] " + name + "가 짖다");
        }//jitda_abs()

    }//class Dog

    public class Jindo : Dog
    {
        public void run()
        {
            Console.WriteLine("Jindo : " + name + " 가 달린다");
        }//work
        public override void jitda_vir()
        {
            Console.WriteLine("[Jindo:Vir/Override] " + name + "가 짖다");
        }//jitda_vir()
        public override void jitda_abs()
        {
            Console.WriteLine("[Jd:ABS/Override] " + name + "가 짖다");
        }//jitda_abs()

    }//class Jindo

    interface Dog_IF
    {
        string name { get; set; }
        void jitda();
    }


    class DogManger
    {
        static void Main(string[] args)
        {
            Pudle p = new Pudle();
            p.name = "푸들이";
            p.jitda();
            p.work();

            Jindo j = new Jindo();
            j.name = "진돌이";
            j.jitda();
            j.run();

            Dog dp = new Pudle();
            dp.name = "푸들이";
            dp.jitda();
            ((Pudle)dp).work();

            object op = new Pudle();
            ((Dog)op).name = "푸들이";
            ((Dog)op).jitda();
            ((Pudle)op).work();

            //Virtual / Override
            p.jitda_vir();
            j.jitda_vir();
            dp.jitda_vir();

            //Abstract / Override
            p.jitda_abs();
            j.jitda_abs();
            dp.jitda_abs();

        } //Main
    }//DogManager
}
