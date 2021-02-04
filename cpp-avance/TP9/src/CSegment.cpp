#include "CSegment.h"
using namespace std;

CSegment::CSegment(): CObjGraph(), m_longueur(0), m_angle(0) {

}

CSegment::CSegment(int const& x, int const& y, int const& couleur, int const& epaisseur,
int const& longueur, double const& angle):
CObjGraph(x, y, couleur, epaisseur), m_longueur(longueur), m_angle(angle) {

}

CSegment::~CSegment() {

}

char* CSegment::get_type() const {
    return (char*) "Type: Ligne";
}

void CSegment::afficher(ostream& out) const {
    CObjGraph::afficher(out);
    
    out << " longueur:" << m_longueur << " angle:" << m_angle;
}

ostream& operator<<(ostream& out, CSegment const& self) {
    self.afficher(out);
    return out;
}

void CSegment::saisir(istream& in) {
    CObjGraph::saisir(in);
    cout << "longueur? > ";
    in >> m_longueur;
    cout << "angle? > ";
    in >> m_angle;
}

istream& operator>>(istream& in, CSegment & self) {
    self.saisir(in);
    return in;
}