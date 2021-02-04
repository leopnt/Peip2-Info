#include "CPoint2D.h"
using namespace std;

//constructeur par défaut
CPoint2D::CPoint2D(): m_x(0), m_y(0) {
    //initialise un point à l'origine
    cout << "Appel du constructeur par defaut de CPoint2D..." << endl;
}

//constructeur paramètre
CPoint2D::CPoint2D(int const& x, int const& y): m_x(x), m_y(y) {

}

//destructeur
CPoint2D::~CPoint2D() {
    cout << "Appel du destructeur de CPoint2D..." << endl;
}

void CPoint2D::afficher(ostream& out) const {
    out << "[" << m_x << "," << m_y << "]" << endl;
}

ostream& operator<<(ostream& out, CPoint2D const& self) {
    self.afficher(out);
    return out;
}

void CPoint2D::saisir(istream& in) {
    cout << "x? > ";
    in >> m_x;
    cout << "y? > ";
    in >> m_y;
}

istream& operator>>(istream& in, CPoint2D & self) {
    self.saisir(in);
    return in;
}

CPoint2D CPoint2D::operator+(CVecteur const& t) {
    //translation du point2D par un vecteur t
    CPoint2D p(m_x, m_y);
    
    if(t.size() >= 1) {
        //on vérifie que la translation est dans le plan 2D

        p.m_x += t.getComposante(0);
        if(t.size() >= 2) {
            p.m_y += t.getComposante(1);
        }
    }
    else {
        cout << "la dimension du vecteur de translation n'est " <<
        "pas compatible avec le point2D" << endl;
    }

    return p;
}