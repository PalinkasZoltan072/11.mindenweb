using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._09._07_alapok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valtozok es tipusok");


            /*
            tipusok
            -szamok:
             int- egész (4B)
               byte, short, long- egész
            double - tört ( lebegőpontos szamok)
            float- tört ( nem fogjuk hasznalni
            Szöveg
                string- (karakterlánc)
            karakter 
                char 1 db karakter érték - 'c'
            logikai
                bool-boolen - true , false
                 
             */
            //valtozok deklaralasa - letrehozas, definialas
            //inicializalas- kezdoertek adas
            //tipus valtozo_nev = érték;


            //egesz szam:
            //int a;

            // int a = 13;
            int a = 13;

               

            Console.WriteLine("egész szám: "+a);

            //tört szam
            double tort = 21.4;
            //kezdoerteknel : 21.4
            // kiiratasnal: 21,4
            //bekeresnel 21,4

            Console.WriteLine("Tört szám: "+tort);

            // konkatenalas - szovegek összefűzése
            // plusz operator (összeg jel)
            // szöveg + szöveg vagy szöveg + érték

            // szöveg
            string sz = "beégetett adat";

            //karakter
            char c = 'h';

            //logika ertek 
            bool logikai = true;

            //hazi a valtozok kiiratasa megadott szoveggel osszefuzve


            //Operatorok
            // aritmetikai
            int b = 11;
            int d = 21;
            int f = 31;

            Console.WriteLine(b + " " + d + " " + f);
            Console.WriteLine("összeadas: " + (b + d));
            Console.WriteLine("kivonas:" + (b - d));
            Console.WriteLine("szorzas:" + (b * d));
            Console.WriteLine("osztas:" + (b / d));
            Console.WriteLine("maradek:" + (b % d));
            Console.WriteLine("erteknovelo:");
            Console.WriteLine("ertekcsokkento:");


            Console.ReadKey();


            
        }
    }
}
