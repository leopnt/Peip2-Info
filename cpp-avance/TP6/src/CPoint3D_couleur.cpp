#include "CPoint3D_couleur.h"
using namespace std;

//constructeur par défaut
CPoint3D_couleur::CPoint3D_couleur(): CPoint3D(), CCouleur(), m_pnom(NULL) {
}

//constructeur paramètre
CPoint3D_couleur::CPoint3D_couleur(int const& x, int const& y, int const& z,
int const& R, int const& G, int const& B, char* const& pnom):
CPoint3D(x, y, z), CCouleur(R, G, B) {
    m_pnom = new char[strlen(pnom)];
    strcpy(m_pnom, pnom);
}

//déstructeur
CPoint3D_couleur::~CPoint3D_couleur() {
    if(m_pnom != NULL) {
        delete[] m_pnom;
    }
    m_pnom = NULL;
}

void CPoint3D_couleur::afficher(ostream& out) const {
    out << m_pnom << ": ";
    CPoint3D::afficher(out);
    out << " ";
    CCouleur::afficher(out);
}

ostream& operator<<(ostream& out, CPoint3D_couleur const& self) {
    self.afficher(out);
    return out;
}

void CPoint3D_couleur::saisir(istream& in) {
    delete[] m_pnom;
    m_pnom = new char;
    cout << "Nom du point? (une seule lettre) > ";
    
    cin >> m_pnom;

    CPoint3D::saisir(in);
    CCouleur::saisir(in);
}

istream& operator>>(istream& in, CPoint3D_couleur & self) {
    self.saisir(in);
    return in;
}
