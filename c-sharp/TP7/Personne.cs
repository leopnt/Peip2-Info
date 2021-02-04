using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    class Personne
    {
        private string m_nom;
        private string m_prenom;
        private char m_sexe;
        private DateTime m_date_naissance;
        private string m_lieu_naissance;


        public Personne()
        {

        }
        public Personne(string nom, string prenom, char sexe, DateTime date_naissance, string lieu_naissance)
        {
            m_nom = nom;
            m_prenom = prenom;
            m_sexe = sexe;
            m_date_naissance = date_naissance;
            m_lieu_naissance = lieu_naissance;
        }

        public int GetAge()
            //TODO: retourner un int et pas un double
        {
            TimeSpan date_diff = DateTime.Today.Subtract(m_date_naissance);
            int age_tot_secondes = Convert.ToInt32(date_diff.Days * 86400
                + date_diff.Hours * 3600
                + date_diff.Minutes * 60);

            return age_tot_secondes / (365 * 86400);
        }
        public string GetNom() { return m_nom; }
        public string GetPrenom() { return m_prenom; }
        public char GetSexe() { return m_sexe; }
        public DateTime GetDateNaissance() { return m_date_naissance; }
        public string GetLieuNaissance() { return m_lieu_naissance; }
        public void SetNom(string nom) { m_nom = nom; }
        public void SetPrenom(string prenom) { m_prenom = prenom; }
        public void SetSexe(char sexe) { m_sexe = sexe; }
        public void SetDateNaissance(DateTime date_naissance) { m_date_naissance = date_naissance; }
        public void SetLieuNaissance(string lieu_naissance) { m_lieu_naissance = lieu_naissance; }
    }
}
