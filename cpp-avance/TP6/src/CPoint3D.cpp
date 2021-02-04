#include "CPoint3D.h"
using namespace std;

//constructeur par défaut
CPoint3D::CPoint3D(): CPoint2D(), m_z(0) {
    //initialise un point à l'origine
    cout << "Appel du constructeur par defaut de CPoint3D..." << endl;
}

//constructeur paramètre
CPoint3D::CPoint3D(int const& x, int const& y, int const& z): CPoint2D(x, y), m_z(z) {

}

//destructeur
CPoint3D::~CPoint3D() {
    cout << "Appel du destructeur de CPoint3D..." << endl;
}

void CPoint3D::afficher(ostream& out) const {
    out << "[" << m_x << "," << m_y << "," << m_z << "]";
}

ostream& operator<<(ostream& out, CPoint3D const& self) {
    self.afficher(out);
    return out;
}

void CPoint3D::saisir(istream& in) {
    cout << "x? > ";
    in >> m_x;
    cout << "y? > ";
    in >> m_y;
    cout << "z? > ";
    in >> m_z;
}

istream& operator>>(istream& in, CPoint3D & self) {
    self.saisir(in);
    return in;
}

void CPoint3D::getNomClass() const {
    cout << "Class CPoint3D" << endl;
}

CPoint3D CPoint3D::operator+(CVecteur const& t) {
    //translation du point3D par un vecteur t
    CPoint3D p(m_x, m_y, m_z);
    
    if(t.size() >= 1) {
        //on effectue la translation

        p.m_x += t.getComposante(0);
        if(t.size() >= 2) {
            p.m_y += t.getComposante(1);
        }
        if(t.size() >= 3) {
            p.m_z += t.getComposante(2);
        }
    }
    else {
        cout << "la dimension du vecteur de translation n'est " <<
        "pas compatible avec le point3D" << endl;
    }

    return p;
}