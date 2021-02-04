using System;
using System.Security.Cryptography;

namespace TP1_Exo2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Entrez du texte > ");
            string chr = Console.ReadLine();

            Console.WriteLine("Nombre de charactère: " + chr.Length);

            if(chr.Contains("e"))
            {

                Console.Write("Position(s) de 'e': ");
                for (int i = 0; i < chr.Length; i++)
                {
                    if(chr[i].ToString() == "e")
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Pas de lettre 'e' dans le texte spécifié...");
            }

            Console.WriteLine("En majuscule: " + chr.ToUpper());

            chr = chr.Insert(chr.Length, "...");

            Console.WriteLine("Avec les trois points: " + chr);
        }
    }
}
