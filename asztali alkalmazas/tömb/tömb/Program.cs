using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tömb
{
    class Program
    {
        static void Main(string[] args)
        {
            // tömb - Array
            // tipus[] tömb_nev; -deklaralas, letrehozas
            // tipus[] tomb_nev = new tipus[elemszam]; (ez a peldanyositas)
            //pl.
            // int[] szamok = new int[11];
            // string[] honapok = new int[12];
            // int[] szamok = new int[]{1,2, 3,4,5,6,7,8,9};
            // string[] szamok = new string[] {"hetfo", "kedd"}
            // HF 26-33 pdf
            int[] szamok = new int[100];
            Random r = new Random();
            int i = 0;
            while (i < szamok.Length)
            {
                int k = r.Next(1, 7);
                szamok[i] = k;
                i += 1;
                
            }
            Console.WriteLine();
            int db = 0;
            int p = 3;
            for (int o = 0; o < szamok.Length; o++)
            {
                Console.Write(szamok[o]+ " ");
                if (szamok[o] == p )
                {
                    db += 1;
                }
                
            }
            Console.WriteLine("ennyi harmas van" + db);



            
            Console.WriteLine("egy szamot 1 és 6 kozott");
            int szam = Convert.ToInt32(Console.ReadLine());
            
            while (szam > 6 || szam < 1)
            {
                Console.WriteLine("nem jót adtál meg");
                szam = Convert.ToInt32(Console.ReadLine());
            }
            int db2 = 0;
            int m = 0;
            while (m < szamok.Length)
            {
                if (szamok[m] == szam)
                {
                    db2 += 1;
                }
                    m += 1;
            }



            int[] szamo = new int[6];
            int h = 0;
            while (h < szamok.Length)
            {
                szamok[i] = k;
                i += 1;
            }
            Console.WriteLine();
            Console.WriteLine("ennyi db van: " + db2);


            Console.ReadKey();
        }
    }
}
