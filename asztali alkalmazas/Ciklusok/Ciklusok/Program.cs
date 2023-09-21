using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklusok
{
    class Program
    {
        static void Main(string[] args)
        {
            // szamlalo ciklus for, tesztelos ciklus whil
            //
            // Szamlalos:
            //        ciklus = i = kezdoertektol vegertekig leptetes
            //          ciklus mag
            // c. v (ciklus vege)
            // for (int i = kezdoertek; i<vegertek)
            //(egy utasitas eseten a zarojel elhagyhato)
            //        ciklus mag

            // elol tesztelos
            //ciklus amig(benmaradasi feltetel(ek))
            //        ciklus mag
            // c.v
            // while(benmaradasi feltetel(ek))
            //{
            //        cikls mag
            //
            //hatul tesztelos
            //
            //csinald
            //       ciklus mag;
            //amig(benmaradasi feltetel(ek));
            //
            //do{
            //        ciklusmag;
            //} while(benmaradasi feltetel(ek));
            //
            //

            // irasd ki az elso 30 pozitiv paros szamot

            for (int i = 2; i <= 60; i += 2) 
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // irasson ki 15 db veletlen szamot [50, 1000] kozott
            // ugy, hogy a szam 10-zel oszhato legyen
            Random r = new Random();
            int a = (r.Next(50, 1001));
            

            for (int i = 0; i< 15; i +=1)
            {
               Console.Write( r.Next(5, 101) * 10 + " ");
            }

            // generalj ki veletlen szamokat [50,1000] addig amig 7-el oszthatot nem kapok
            int a;
            do
            {
                int b = (r.Next(50, 1001));
                Console.WriteLine(a + " ");

            }
            while (a % 7 != 0);

            //hf 26 27 28





            Console.ReadKey();
        }
    }
}
