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
            string b = "senki sem tokeletes de a  programozok atkozottul kozel allnak hozza.";
            while (bet.Length != 2)
            {
                
                bet = Console.ReadLine();
            }

            int i = 0;
            while (i < b.Length-1 && !(b[i] == bet[0] && (b[i+1] == bet[1])))
            {
                i += 1;
            }
            if (i < b.Length - 1) 
            {
                Console.WriteLine("Van benne {0} dupla betű.", bet);
            }
            else
            {
                Console.WriteLine("Nincs {0} dupla betű.", bet);
            }

            // Ascii kód

            // karakter abrazolas
            // S = 83, e = 101
            char karakter = 'c';
            Console.WriteLine(karakter);
            int karakterkod = (int)karakter;
            int kk = 100;
            
            char k = (char)kk;
            Console.WriteLine(kk);

            //hf jelszo generalas kerjen be a felhaszn.tol a teljes nevet (feltetelezzuk 2 szbol all pl kis pista) generalj ki neki egy felhasznalo nevet ket szo elso harom betujebol(kisbetuket legyenek)generalj melle 10 hosszu kis es nagy betukbol allo jelszot



            string nev = "Kis Pista";
            Console.WriteLine(nev);

            string vnev = "", knev = "";

            int j = 0;

            while (j < nev.Length && nev[j] != ' ')
            {
                vnev += nev[j];
                j += 1;
            }

            j = nev.Length - 1;

            while (j>= 0 && nev[j] != ' ')
            {
                knev = nev[j] + knev;
                j -= 1;
            }

            Console.WriteLine(vnev);
            Console.WriteLine(knev);

            string azonosito = "";

            if (vnev.Length< 3)
            {
                azonosito += vnev;
            }
            else
            {
                azonosito += ""+vnev[0] + vnev[1] + vnev[2];
            }

            if (knev.Length < 3)
            {
                azonosito += knev;
            }
            else
            {
                azonosito += ""+ knev[0] + knev[1] + knev[2];
            }

            knev = knev.ToLower();
            vnev = vnev.ToLower();
            //knev = knev.ToUpper();

            Random r = new Random;
            string jelszo = "";
            for (int x = 0; x < 10; x++)
            {
                int milegyen = r.Next(1, 4);
                if (milegyen == 1)
                {
                    jelszo += (char)r.Next(97, 123);
                }
                else if (milegyen == 2)
                {
                    jelszo += (char)r.Next(65, 91);
                }
                else
                {
                    jelszo += (char)r.Next(0, 10);
                }
            }


            /*
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
                */

            Console.ReadKey();
        }
    }
}
