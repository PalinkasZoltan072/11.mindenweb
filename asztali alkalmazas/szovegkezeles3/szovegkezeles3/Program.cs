using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szovegkezeles3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 14-25-ig pdf hazi jovohet 23.10.09-ig
            // kerj be a felhasznalotol egy dubla betut(hossza = 2 ")
            // addig kerjen be  a program amig nem azt adja ami megfelel 
            // adott egy szoveg 
            // szoveg: senki sem tokeletes de a  programozok atkozottul kozel a
            // allnak hozza.

            

            
            

            Console.WriteLine("egy dubla betut");
            string bet = Console.ReadLine();
            while (bet.Length != 2)
            {
                
                bet = Console.ReadLine();
            }
            Console.WriteLine();



            char a1 = bet[0];
            char a2 = bet[1];
            int c = 0;

            string b = "senki sem tokeletes de a  programozok atkozottul kozel allnak hozza.";
            for (int i = 0; i < b.Length; i+=1)
            {
                if (b[i]  == a1 )
                {
                    if (b[i+1] == a2)
                    {
                        c += 1;
                    }

                }
                

            }


            if (c > 0)
            {
                Console.WriteLine("van benne");
            }
            else
            {
                Console.WriteLine("nincs benne");
            }
            
            Console.ReadKey();
        }
    }
}
