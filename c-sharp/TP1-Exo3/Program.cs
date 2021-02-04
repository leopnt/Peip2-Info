using System;
using System.Collections.Generic;

namespace TP1_Exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tab = new List<int>(new int[10]);
            for(int i = 0; i < tab.Count; i++)
            {
                Console.Write("tab[" + i + "] > ");
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            //cherche la valeur max
            int max = 0;
            for(int i = 0; i < tab.Count; i++)
            {
                if(max < tab[i])
                {
                    max = tab[i];
                }
            }
            Console.WriteLine("Maximum du tableau: " + max);

            Console.WriteLine("Moyenne: " + Moyenne(tab));

            tab.Sort();
            Console.Write("[");
            Console.Write(String.Join(", ", tab));
            Console.WriteLine("]");
        }

        static public double Moyenne(List<int> l)
        {
            double S = 0;
            for (int i = 0; i < l.Count; i++)
            {
                S += l[i];
            }

            return S / Convert.ToDouble(l.Count);
        }
    }
}
