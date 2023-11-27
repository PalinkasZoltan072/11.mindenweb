using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_17_Rendezesek
{
    class Program
    {
        static int[] t = new int[20];
        static void Main(string[] args)
        {
            Tombfeltoltes(t);
            TombKiiratas(t);
            Console.WriteLine();
            //egyszerucsere(t);
            //minikivalasztas(t);
            //buborekos(t);
            //beilleszteses(t);
            

            Console.ReadKey();
        }

        

        static void buborekos(int[] t) 
        {
            int cserelt = 0;
            for (int i = t.Length; i > 2; i-=1)
            {
                for (int j = 1; j < i-1; j++)
                {
                    if (t[j] > t[j+1])
                    {
                        cserelt = t[j];
                        t[j] = t[j+1];
                        t[j+1] = cserelt;
                    }
                    TombKiiratas(t);
                }
            }

        }

        static void beilleszteses(int[] tomb) 
        {
            
            for (int i = 2; i < tomb.Length; i++)

            {
                int j = i - 1;
                while (j > -1  && tomb[j] > tomb[j+1])
                {
                    
                    int csere = 0;
                    csere = tomb[j];
                    tomb[j] = tomb[j+1];
                    tomb[j + 1] = csere;
                    j = j - 1;
                    




                }

                TombKiiratas(t);
            }

        }

        static void minikivalasztas(int[] tomb)
        {
            int cserel = 0;
           for (int i = 1; i < tomb.Length-1; i++) 
            {
                
                int min = i;
                for (int j = i + 1; j < tomb.Length; j++)
                {
                    
                    if (tomb[min] > tomb[j])
                    {
                        min = j;
                        

                    }
                    
                }
                cserel = tomb[i];
                tomb[i] = cserel;
                tomb[min] = cserel;

                

            }
        }


        static void egyszerucsere(int[] tomb)
        {
            for (int i = 0; i < tomb.Length - 1; i++)
            {
                for (int j = i + 1; j < tomb.Length; j++)
                {
                    if (tomb[i] > tomb[j])
                    {
                        int csere = tomb[i];
                        tomb[i] = tomb[j];
                        tomb[j] = csere;
                        TombKiiratas(t);
                    }
                    
                }
            }
        }

        static void TombKiiratas(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
                Console.Write(tomb[i] + " ");
            Console.WriteLine();
        }

        static void Tombfeltoltes(int[] tomb)
        {
            Random r = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(1, 100);
            }
            
        }

    }
}

