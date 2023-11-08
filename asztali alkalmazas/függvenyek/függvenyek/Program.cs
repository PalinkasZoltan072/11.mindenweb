using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace függvenyek
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * matodusok
             * fuggvenyek, eljarasok, (konstruktor)
             * fuggvenyek -Visszatérési érték (return)
             * Eljarasok - függvény, aminek nincs visszatérési értéke.
             * A main eljarasban csak eljaras meghivsaok lehetnek és billentyuzetre valtas
             *
           */

            feladat1();

            Console.WriteLine(feladat2());

            feladat3();

            Console.ReadKey();
        }

        static void feladat3()
        {
            int a = 12;
            int b = 13;
            kiiratas(a,b);
            Console.WriteLine("ket szam osszege: " + Osszeg(a,b));
        }

        static int Osszeg(int szam1, int szam2)
        {
            return szam1 + szam2;
        }

        static void kiiratas(int szam1, int szam2)
        {
            Console.WriteLine("szam1={0}", szam1);
            Console.WriteLine("szam2={0}", szam2);
        }

        static string feladat2()
        {
            return "EZ egy visszateresi ertekkel rendelkezo fugveny";
        }


        static void feladat1()// eljaras + neve ( nincs visszateresi ertek)
        {
            Console.WriteLine("ez egy eljaras");
        }

        hf 38 abc



    }


}
