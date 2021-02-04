#include "CCouleur.h"
using namespace std;

CCouleur::CCouleur() {

}

CCouleur::CCouleur(int const& R, int const& G, int const& B) {
    m_color.push_back(R);
    m_color.push_back(G);
    m_color.push_back(B);
}

CCouleur::~CCouleur() {

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

void CCouleur::operator=(CCouleur const& nouvCouleur) {
    m_color[0] = nouvCouleur.m_color[0];
    m_color[1] = nouvCouleur.m_color[1];
    m_color[2] = nouvCouleur.m_color[2];
}