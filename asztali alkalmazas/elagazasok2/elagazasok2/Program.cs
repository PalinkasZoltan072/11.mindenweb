using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elagazasok2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * elagazasok
             * ha(feltetel(ek))
             *  szekvencia;
             *  
             *  if(feltetel(ek)
             *  //egy utasitas eseten elhagyhato a  zarojel
             *  szekvencie
             *  
             *  ha (feltel(ek))
             *      szekvencia1;
             *  kulonben
             *      szekvencia2
             *      
             *  if(feltetel (ek))
             *   { 
             *       szekvencia1;
             *   else
             *   {
             *       szekvencia2;
             *   }
             *   
             *   if(feltetel(ek))
             *          szekvencia1;
             *   else if(feltetel(ek))
             *          szekvencia2;
             *   ...
             *   else 
             *          SzekvenciaN;
             *          
             *          
             *   switch(valtozo)
             *   {
             *      case érték1: szekvencia1;
             *          break;
             *      case érték2: szekvencia2;
             *          break;
             *      case érték3: szekvencia2;
             *          break;
             *      case érték4: szekvencia2;
             *          break;
             *      default : SzekvenciaN;
             *          break;
             *       *    }
             *    
             */
            Console.WriteLine("Írjon be egy napot:");
            string nap = Console.ReadLine();
            Console.WriteLine(nap);

            switch (nap)
            {
                case "hetfő":
                    Console.WriteLine("raguleves");
                    break;
                default:
                    Console.WriteLine("hibas napot adott meg");
                    break;


                    // hf pdf 7-9 


                 
            }

            // hf 10-13-ig 2023.09.20!!!!!!!!!

            // generalj ki egy veletlen szamot [-10, 10] között. Szorozd össze két értéket. ha a szorzat kiesik az intervallumbol akkor ezt jelezzuk a felhasznalonak
            // Ha az ntervallumon belül van, akkor irassuk ki


            Random r = new Random();
            int a = (r.Next(-10, 11));
            int b = (r.Next(-10, 11));
            int szorzat = a * b;

            if( szorzat>=-10 && szorzat<=10 )
            {
                Console.WriteLine("A szorzat " + szorzat);
                }
            else
            {
                Console.WriteLine("A szorzat nincs benne az intervallumban");


            }

            //az ekezet betuket szeretnem lecserelni. kerjen be egy a felhasznalotol egy ekezetes betut es irassa ki ekezet nelkul! ha nem jo betut adott meg, jelezze a felhasznalonak!





            Console.WriteLine("ekezetes betu:");
            string betu = Console.ReadLine();
            


            switch (betu)
            {
                case "á":
                    Console.WriteLine("a");
                    break;
               
                case "é":
                    Console.WriteLine("e");
                    break;
               
                case "í":
                    Console.WriteLine("i");
                    break;
                
                case "ó":
                    Console.WriteLine("o");
                    break;
                
                case "ö":
                    Console.WriteLine("o");
                    break;
                
                case "ő":
                    Console.WriteLine("o");
                    break;
                
                case "ú":
                    Console.WriteLine("u");
                    break;
               
                case "ü":
                    Console.WriteLine("u");
                    break;
               
                case "ű":
                    Console.WriteLine("u");
                    break;
                default:
                    Console.WriteLine("hibas betut adott meg");
                    break;




            }






            Console.ReadKey();
        }
    }
}
