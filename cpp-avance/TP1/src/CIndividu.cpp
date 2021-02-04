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
    m_nom = new char;
    m_prenom = new char;

    strcpy(m_nom, nom);
    strcpy(m_prenom, prenom);
}

CIndividu::~CIndividu() {
    delete[] m_nom;
    delete[] m_prenom;
}

ostream& operator<<(ostream &out, CIndividu const& self) {
    out << "Etat civil: " << self.m_nom << " " << self.m_prenom << endl
    << "Annee de naissance: " << self.m_annee_naissance;

    return out;
}

istream& operator>>(std::istream &in, CIndividu & self) {
    cout << "NOM? > ";
    in >> self.m_nom;
    
    cout << "Prenom? > ";
    in >> self.m_prenom;
    
    cout << "Annee de naissance XXXX? > ";
    in >> self.m_annee_naissance;

    return in;
}