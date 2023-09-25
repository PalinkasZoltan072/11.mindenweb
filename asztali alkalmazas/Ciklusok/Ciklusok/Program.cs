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
            
            

            for (int i = 0; i< 15; i +=1)
            {
               Console.Write( r.Next(5, 101) * 10 + " ");
            }
            Console.WriteLine();

            // generalj ki veletlen szamokat [50,1000] addig amig 7-el oszthatot nem kapok



            //hf 26 27 28

            for (int i = 1; i < 11; i += 1)
            {
                int z = r.Next(5, 101);
                Console.Write(z + " ");
            }
            Console.WriteLine();


            //27

            double  u = 0;

            for (int i = 1; i < 11; i += 1)
            {
                int z = r.Next(5, 101);
                u += z;
                
            }
            Console.Write((u / 10) + " ");
            Console.WriteLine();

            //28
            int l = r.Next(10, 100);
            while (!(l % 7 == 0))
            {
                l = r.Next(10, 100);
            }
            Console.WriteLine(l+" ");

            Console.ReadKey();
        }
    }
}
