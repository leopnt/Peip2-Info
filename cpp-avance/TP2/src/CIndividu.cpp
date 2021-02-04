#include "CIndividu.h"
using namespace std;

CIndividu::CIndividu(): m_nom(NULL), m_prenom(NULL), m_annee_naissance(0) {
    m_nom = new char;
    m_prenom = new char;
}

CIndividu::CIndividu(CIndividu const& individu):
m_annee_naissance(individu.m_annee_naissance) {
    m_nom = new char;
    m_prenom = new char;

    strcpy(m_nom, individu.m_nom);
    strcpy(m_prenom, individu.m_prenom);
}

CIndividu::CIndividu(char* const& nom, char* const& prenom, int const& annee_naissance):
m_annee_naissance(annee_naissance) {
    //on efface dans le cas ou l'opérateur = est appelé
    delete[] m_nom;
    delete[] m_prenom;
    
    m_nom = new char;
    m_prenom = new char;

    strcpy(m_nom, nom);
    strcpy(m_prenom, prenom);
}

CIndividu::~CIndividu() {
    delete[] m_nom; m_nom = NULL;
    delete[] m_prenom; m_prenom = NULL;
}

void CIndividu::afficher(ostream& out) const {
    out << "Etat civil: " << m_nom << " " << m_prenom << endl
    << "Annee de naissance: " << m_annee_naissance;
}

ostream& operator<<(ostream &out, CIndividu const& self) {
    self.afficher(out);    
    return out;
}

void CIndividu::saisir(istream &in) {
    cout << "NOM? > ";
    in >> m_nom;
    
    cout << "Prenom? > ";
    in >> m_prenom;
    
    cout << "Annee de naissance XXXX? > ";
    in >> m_annee_naissance;
}

istream& operator>>(std::istream &in, CIndividu & self) {
    self.saisir(in);
    return in;
}