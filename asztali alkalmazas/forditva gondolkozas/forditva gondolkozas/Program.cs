using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forditva_gondolkozas
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            // toltson fel egy tombot az elso 23 darab 7-el oszthato szammal!
            //keverje ossze a tomb elemeit egy on altal valasztott algoritmussal
            // szamold meg hany csere tortenik amikor a szamot onmagaval csereli ki
            // HAZI TOLTSON FEL EGY 13 ELEMU TOMBOT [10.31] KOZOTTI SZAMOT UGY HOGY NEM ISMETLODHETAZ ERTEK A TOMBBEN

            int[] tomb = new int[23];
            int szam = 0;
            int db = 0;
            int i = 0;

            int db2 = 0; 




            tombfeltoltes(tomb, szam, db, i);
            keveres(tomb, db2);
            
            




            Console.ReadKey();

        }

        static void csere( ref int szam1, ref int szam2)
        {
            
            int cseres = szam1;
            szam1 = szam2;
            szam2 = cseres;

            if (true)
            {

            }


        }

        

        static void keveres(int[] tomb, int DB2)
           {
            Random r = new Random();

            for (int i = 0; i < 200; i++)
            {
                int a = r.Next(0, tomb.Length);
                int b = r.Next(0, tomb.Length);
                csere(ref tomb[a], ref tomb[b] );
                // tomb[a] ertek tipusu valtozok, az eljaras lefutasa utan , ha nem hasznalok ref-et akkor nem a megvaltozott ertekkel dolgozik tovabb.

            }

           }

       

        static void tombfeltoltes(int[] tomb, int szam, int db, int i)
        {
            

            while (db < 23)
            {
                
                if (szam % 7 == 0)
                {
                    tomb[i] = szam;
                    i += 1;
                    db += 1;
             
                }
                szam += 1;

            }
        }
    }
}
