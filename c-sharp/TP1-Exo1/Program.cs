using System;

namespace TP1_Exo1
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Entrez la longueur et la largeur:");
            Console.Write("largeur? > ");
            int largeur = Convert.ToInt32(Console.ReadLine());
            Console.Write("longueur? > ");
            int longueur = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Surface = " + largeur * longueur);
        }
    }
}
