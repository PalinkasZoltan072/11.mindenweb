using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szovegkezeles2
{
    class Program
    {
        static void Main(string[] args)
        {
            string szoveg = "kalapacs";
            Console.Write("Adjon meg egy darab betut ");
            string b = Console.ReadLine();
            char c = Convert.ToChar(b);
            string ujszoveg = "";
            
            for(int i = 0; i <szoveg.Length; i += 1)
            {
                if (szoveg[i] == 'a')
                   {
                    ujszoveg += c;
                }
                else
                {
                    ujszoveg += szoveg[i];
                }
            }
            Console.WriteLine(ujszoveg);

            //van-e benne bizonyos betu
            int index = 0;
            while (index<szoveg.Length && szoveg[index] != c)
            {
                index += 1;
            if (index < szoveg.Length)
                {
                    Console.WriteLine("van a szovegben {0} valamilyen betu" , c);
                }
                else
                {
                    Console.WriteLine("van a szovegben {0} nincs valamilyen betu");
                }
            }
            Console.ReadLine();
            

        }
    }
}
