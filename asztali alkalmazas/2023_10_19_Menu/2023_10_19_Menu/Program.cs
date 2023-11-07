﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_10_19_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu, a = 0 ,b=0 ,c= 0; // logikai = false
            bool megavdott = false;
            do
            {
                
                menukiiratasa();
                menu = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                switch (menu)
                {
                    case 1:
                        ketszammegadasa(ref a, ref b);
                        
                        c = +1; // logikai = true
                        break;
                    case 2:
                        // if (!logikai)
                        osszeadas( c,  b,  a);
                        
                        
                        break;
                    case 3:
                        if (c == 0)
                        {
                            Console.WriteLine("nem jo");
                        }
                        else
                        {
                            Console.WriteLine("szorzat");
                            Console.WriteLine("{0} * {1}= {2}", a, b, a * b);
                        }
                        
                        break;
                    case 0:
                        Console.WriteLine("kilépés");
                        break;
                    default:
                        Console.WriteLine();
                        break;
                        // hf menu keszites ilyet akkor az egyes menu feltolt egy 11 elemu tombot 2-es szamok atlaga vizsgalat a feltoltes  utan 3 menu pont megadja a legnagyobb szam helyet! 
                }
                Console.ReadLine();
            } while (menu != 0);
        }
        static void osszeadas( int c,  int a,  int b)
        {
            if (c == 0)
            {
                Console.WriteLine("nem jo");
            }
            else
            {
                Console.WriteLine("összeg");
                Console.WriteLine("{0} + {1}= {2}", a, b, a + b);
            }
        }
        static void ketszammegadasa( ref int a, ref int b)
        {
            Console.WriteLine("be: két szám");

            Console.Write("szam 1");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("szam 2");
            b = Convert.ToInt32(Console.ReadLine());
        }
        static void menukiiratasa()
        {
            Console.Clear();
            Console.WriteLine("1. - Két szám megadása");
            Console.WriteLine("2. - A két szám összege");
            Console.WriteLine("3. - A két szám szorzata");
            Console.WriteLine("0. - Kilépés");
            Console.Write("Adjon meg egy menüpontot: ");
        }
    }
}
