#include "CIndividu.h"
using namespace std;

CIndividu::CIndividu(): m_nom("NOM"), m_prenom("Prenom"), m_annee_naissance(1970) {
    
}

CIndividu::CIndividu(CIndividu const& individu): m_nom(individu.m_nom),
m_prenom(individu.m_prenom), m_annee_naissance(individu.m_annee_naissance) {

}

CIndividu::CIndividu(string const& nom, string const& prenom, int const& annee_naissance):
m_nom(nom), m_prenom(prenom), m_annee_naissance(annee_naissance) {

}

CIndividu::~CIndividu() {

}

void CIndividu::affiche(ostream &out) const{
    out << "Etat civil: " << m_nom << " " << m_prenom << endl
    << "Annee de naissance: " << m_annee_naissance;
}

ostream& operator<<(ostream &out, CIndividu const& self) {
    self.affiche(out);
    
    return out;
}

void CIndividu::saisir(istream &in) {
    in.ignore(); //pour éviter les bugs avec les espaces dans le buffer
    
    cout << "NOM? > ";
    getline(in, m_nom);
    
    cout << "Prenom? > ";
    getline(in, m_prenom);
    
    cout << "Annee de naissance XXXX? > ";
    in >> m_annee_naissance;
}

istream& operator>>(std::istream &in, CIndividu & self) {
    self.saisir(in);
    return in;
}