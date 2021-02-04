#include "CCouleur.h"
using namespace std;

CCouleur::CCouleur() {
    //on initialise les valeurs à 0 --> couleur noir
    cout << "Appel du constructeur par defaut de CCouleur..." << endl;

    for(int i = 0; i < 3; i++) {
        m_color.push_back(0);
    }
}

CCouleur::CCouleur(int const& R, int const& G, int const& B) {
    m_color.push_back(R);
    m_color.push_back(G);
    m_color.push_back(B);
}

//constructeur copie
CCouleur::CCouleur(CCouleur const& nouvCouleur) {
    for(int i = 0; i < nouvCouleur.m_color.size(); i++) {
        m_color.push_back(nouvCouleur.m_color[i]);
    }
}

CCouleur::~CCouleur() {
    cout << "Appel du destructeur de CCouleur..." << endl;
}

void CCouleur::afficher(ostream& out) const{
    out << "(R:" << m_color[0] <<
    ", G:" << m_color[1] <<
    ", B:" << m_color[2] << ")";
}

ostream& operator<<(ostream& out, CCouleur const& self) {
    self.afficher(out);
    return out;
}

void CCouleur::saisir(istream& in) {
    cout << "R? > ";
    in >> m_color[0];
    cout << "G? > ";
    in >> m_color[1];
    cout << "B? > ";
    in >> m_color[2];
}

istream& operator>>(istream& in, CCouleur & self) {
    self.saisir(in);
    return in;
}

void CCouleur::getNomClass() const {
    cout << "Classe CCouleur" << endl;
}

void CCouleur::operator=(CCouleur const& nouvCouleur) {
    for(int i = 0; i < m_color.size(); i++) {
        m_color[i] = nouvCouleur.m_color[i];
    }
}