using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozatra_gyakorlás
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int gyok = 0;
            int db = 0;
             int t = r.Next(10, 100);
            Console.WriteLine(t);
            for (int i = 0; i < t; i++)
            {
                int z = r.Next(100, 301);
                Console.Write(z + " ");

                if (z % 2==0)
                {
                    db ++;

                    gyok += z;
                }


                
            }
            Console.WriteLine();
            Console.WriteLine("ennyi paros szam van " + db);
            Console.WriteLine();
            Console.WriteLine("gyok osszeadas " + Math.Round(Math.Sqrt(gyok),2 ) );



            Console.ReadKey();
        }
    }
}
