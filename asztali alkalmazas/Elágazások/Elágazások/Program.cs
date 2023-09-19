using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elágazások
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
               case "hetfő": Console.WriteLine("raguleves")
                    break;
                default: Console.WriteLine("hibas napot adott meg");
                    break


                        pdf 7,8,9

            
            
            }
             


            Console.ReadKey();
        }
    }
}
