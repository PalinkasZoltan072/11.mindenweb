using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._11._14
{
    class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();

            feltoltes();

            int a = r.Next();
        }

        static void feltoltes(Random r)
        {
            int tombdhossz = r.Next(10, 100);
            for (int i = 0; i < tombdhossz; i++)
            {

            }
        }
    }
}
