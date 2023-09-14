using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_20_ig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            // Console.WriteLine(rnd.NextDouble() * 10 + 10);
            float r = rnd.Next(1000, 2001);
            Console.WriteLine((r / 100));
            Console.ReadKey();

        }
    }
}
