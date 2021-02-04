using System;
using System.Collections.Generic;
using System.Text;

namespace TP2
{
    class Personne
    {
        private string m_nom;
        private string m_prenom;
        private double m_taille;
        private double m_masse;

        public Personne()
        {
        }

        private double ICM()
        {
            return (m_masse / Math.Pow(m_taille, 2));
        }

        public void Legende()
        {
            if (ICM() < 16.5) Console.WriteLine("dénutrition");
            if (ICM() >= 16.5 && ICM() < 18.5) Console.WriteLine("maigreur");
            if (ICM() >= 18.5 && ICM() < 25) Console.WriteLine("corpulence normale");
            if (ICM() >= 25) Console.WriteLine("surpoids");

            Console.WriteLine("(ICM: " + ICM() + ")");
        }

        public string GetNom() { return m_nom; }
        public void SetNom(string nom) { m_nom = nom; }
        public string GetPrenom() { return m_prenom; }
        public void SetPrenom(string prenom) { m_prenom = prenom; }
        public double GetTaille() { return m_taille; }
        public void SetTaille(double taille) { m_taille = taille; }
        public double GetMasse() { return m_masse; }
        public void SetMasse(double masse) { m_masse = masse; }
    }
}
