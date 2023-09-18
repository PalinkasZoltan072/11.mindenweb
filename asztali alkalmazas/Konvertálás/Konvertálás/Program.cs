using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konvertálás
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine(Math.Round(r.NextDouble() * 10 + 10, 2));

            double a = r.Next(1000, 2001);
            Console.WriteLine(a / 100);

            a = r.Next(100, 401);
            Console.WriteLine(Math.Round(Math.Sqrt(a), 2));
            // Konverziók
            string beszam = "12";
            int egesz = Convert.ToInt32(beszam);
            Console.WriteLine(egesz * 2);

            string Betort = "12,54";
            double tort = Convert.ToDouble(Betort);
            Console.WriteLine(Math.Sqrt(tort));

            // int.Parse vs convert.Toint32()
            Console.WriteLine(Convert.ToInt32(true));
            Console.WriteLine(Convert.ToInt32(null));

            double te = 12.3;
            // int et = Convert.ToInt32(te);
            int et = (int)te;  // tort es szam kozott letezik
            Console.WriteLine(et);



            int id = 13;
            Console.WriteLine((double)id / 3);
            // szövegge alakitas
            int b = 123;
            //string szb =Convert.ToString(b);
            //string szb =b.ToString();
            string szb =""+b;

            Console.WriteLine(szb);

            // kiiratasi lehetosegek
            string nev = "";
            int kor = 12;
            string cim = "cegled kossuth f. u 32";
            bool ferfi = true;
            //Console.WriteLine("Név:" + nev + "kor: " + kor + "cim + cim +"ferfi: " + ferfi);



            Console.WriteLine("név: {0} Kor: {1} cim: {2} ferfi: {3}", nev, kor, cim, ferfi);


            Console.WriteLine($"név: {nev} Kor: {kor} cim: {cim} ferfi: {ferfi}");



            //felhasznalotol ertek bekeres
            Console.WriteLine("Írjon be egy szöveget:");
            string szoveg = Console.ReadLine();
            Console.WriteLine(szoveg);

            Console.Write("Adjon meg egy egész számot");
            string be = Console.ReadLine();
            //int beegesz = Convert.ToInt32(be);
            int beegesz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A szám kétszerese" + beegesz * 2);


            // HF feladatok 2021-2022-pdf 1-6

            // 1.
            int c = 10;
            int d = 10;


            Console.WriteLine("Kerület: " + (2 * (c + d)));
            Console.WriteLine("Terület: " + (c * d));
            //2.
            double s = 5;
            double PI = 3.1415926535897931;

            Console.WriteLine("Kör atmeröje: " + (s *= 2));
            Console.WriteLine("Kör Kerülete: " + (2 * s * PI));
            Console.WriteLine("Kör területe: " + (s * s * PI));
            //3.
            double ha = 5;
            double hb = 5;
            double hc = 5;

            s = ((ha + hb + hc) / 2);


            Console.WriteLine("Háromszög kerülete: " + (s * 2));
            Console.WriteLine("Háromszög kerülete: " + (Math.Sqrt(s * (s - ha) * (s - hb) * (s - hc))));
            //4.
            double szha = 5;

            Console.WriteLine("Sz. Háromszög magassága: " + (Math.Sqrt(Math.Pow(szha, 2) + (Math.Pow(szha / 2, 2)))));

            double sqrt = 5;
            double sqrtla = Math.Sqrt(Math.Pow(sqrt, 2) + Math.Pow(sqrt, 2));


            //5.
            Console.WriteLine("Kocka lap átlója: " + sqrtla);
            Console.WriteLine("Kocka test átlója: " + (Math.Sqrt(Math.Pow(sqrtla, 2) + Math.Pow(sqrt, 2))));
            //6.
            Console.Write("Vezetéknév: ");
            string Vn = Console.ReadLine();
            Console.Write("Keresztnév: ");
            string Kn = Console.ReadLine();


            Console.ReadKey();

        }
    }
}
