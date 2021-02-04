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
