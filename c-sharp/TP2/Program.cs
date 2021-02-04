using System;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne personne = new Personne();

            Console.Write("Nom? > ");
            personne.SetNom(Console.ReadLine());
            Console.Write("Prenom? > ");
            personne.SetPrenom(Console.ReadLine());
            Console.Write("Taille? > ");
            personne.SetTaille(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Masse? > ");
            personne.SetMasse(Convert.ToDouble(Console.ReadLine()));

            personne.Legende();
        }
    }
}
