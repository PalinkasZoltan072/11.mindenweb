using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Szovegkezeles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*szovegkezeles
             * string - karakterlanc- karaktertömb
             * csak olvashato ertek  - a karaktereket kulo.kulon le lehet kerni, de nem valtoztathatok meg
             * string szoveg = "kalapacs";
             * pl. elso karakter: szoveg[0]
             * szoveg hossza : szoveg.length
             * szoveg[0] = "A"; Ilyet nem lehet!!!*/
            string szoveg = "kalapacs";

            Console.WriteLine(szoveg);
            // szoveg hossza
            // egymasala kiiratas
            // elso , utolso karakter
            // szoveg feldolgozas nincs benne a dogaba
            
            for (int i = 0; i<szoveg.Length; i += 1)
            {
                Console.WriteLine(szoveg[i]);
            }
            Console.WriteLine();

            // string[] cars = {"volvo" }

            // hf gyujtsd ki a szoveg minden masodik karakteret !, majd nezd meg van-e benne a felhasznalotol bekert betut!
            // 14-17-ig pdf

            Console.WriteLine(szoveg[0]);
            Console.WriteLine();
            Console.WriteLine(szoveg.Length);
            Console.WriteLine();
            Console.WriteLine(szoveg[szoveg.Length-1]);
            Console.WriteLine();

            Console.Write("Adjon meg egy darab betut ");
            string m = Console.ReadLine();
            char ű = Convert.ToChar(m);


            for (int i = 1;i<szoveg.Length;i += 2)
            {
                
                if (szoveg[i] == ű)
                {
                    Console.WriteLine("VAN");
                }
                else
                {
                    Console.WriteLine("nincs");
                }
                
            }
            Console.WriteLine();
            


            //14 
            Console.Write("Adjon meg egy betut ");
            string v = Console.ReadLine();
            Console.WriteLine(v[0]);
            Console.WriteLine();
            Console.WriteLine(v[v.Length-1]);
            Console.WriteLine() ;
            // 15
            if (v[0] == v[v.Length - 1])
            {
                Console.WriteLine("IGEN");
            }
            else {
                Console.WriteLine("NEM");
            }
            

            Console.WriteLine();
            // 16
            for (int i = 1; i < v.Length; i += 2)
            {

                Console.Write( v[i]);

            }
            Console.WriteLine();
            // 17
            Console.WriteLine();

            for (int i =(v.Length-1); i >= 0; i -= 1)
            {
                
                Console.WriteLine(v[i]);

            }
            Console.WriteLine();





            Console.ReadKey(); 
        }
    }
}
